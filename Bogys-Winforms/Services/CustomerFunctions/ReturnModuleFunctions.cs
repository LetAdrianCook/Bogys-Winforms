using Bogys_Winforms.Models;
using Bogys_Winforms.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Services.CustomerFunctions
{
    class ReturnModuleFunctions
    {
        StringsVariables strTxt = new StringsVariables();
        public List<Rent> GetCustomerRent(int customerID)
        {
            using (var context = new AppDbContext())
            {
                return context.Rent
                .Where(r => r.UserID == customerID)
                .Select(r => new Rent
                {
                    ID = r.ID,
                    VideoID = r.VideoID,
                    CustomerName = r.CustomerName,
                    VideoTitle = r.VideoTitle,
                    VideoCategory = r.VideoCategory,
                    OverdueFee = r.OverdueFee,
                    RentDays = r.RentDays,
                    RentDate = r.RentDate,
                    ReturnDate = r.ReturnDate,
                    Status = r.Status
                }).ToList();
            }
        }
        public void HeaderTitle(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dataGridView.Columns[strTxt.ID].Visible = false;
            dataGridView.Columns[strTxt.UserID].Visible = false;
            dataGridView.Columns[strTxt.CustomerName].Visible = false;
            dataGridView.Columns[strTxt.VideoID].Visible = false;
            dataGridView.Columns[strTxt.VideoTitle].HeaderText = strTxt._VideoTitle;
            dataGridView.Columns[strTxt.VideoCategory].HeaderText = strTxt._VideoCategory;
            dataGridView.Columns[strTxt.OverdueFee].HeaderText = strTxt._OverdueFee;
            dataGridView.Columns[strTxt.RentDays].HeaderText = strTxt._RentDays;
            dataGridView.Columns[strTxt.RentDate].HeaderText = strTxt._RentDate;
            dataGridView.Columns[strTxt.ReturnDate].HeaderText = strTxt._ReturnDate;
        }
        public void UpdateAllOverdueFees()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    DateOnly today = DateOnly.FromDateTime(DateTime.Today);
                    var overdueItems = context.Rent.Where(r => r.ReturnDate < today).ToList();

                    foreach (var rentedVideo in overdueItems)
                    {
                        if (rentedVideo.Status != strTxt.overdue) rentedVideo.Status = strTxt.overdue;

                        int daysOverdue = today.DayNumber - rentedVideo.ReturnDate.DayNumber;
                        float fee = daysOverdue * 5f;
                        rentedVideo.OverdueFee = fee;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(strTxt.updateFeesMsg + ex.Message);
            }
        }
        public bool ReturnMovie(int rentalId)
        {
            using (var context = new AppDbContext())
            {
                using (var returnVideo = context.Database.BeginTransaction())
                {
                    try
                    {
                        var rentedMovie = context.Rent.FirstOrDefault(r => r.ID == rentalId);
                        if (rentedMovie == null) return false;

                        var video = context.Video.FirstOrDefault(v => v.ID == rentedMovie.VideoID);
                        if (video == null) return false;

                        video.VideoInCount += 1;
                        video.VideoOutCount -= 1;

                        context.Rent.Remove(rentedMovie);

                        context.SaveChanges();
                        returnVideo.Commit();
                        return true;
                    }
                    catch
                    {
                        returnVideo.Rollback();
                        throw;
                    }
                }
            }
        }

    }
}
