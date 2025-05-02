using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bogys_Winforms.Windows.Customer
{
    public partial class ReturnModule : UserControl
    {
        public ReturnModule()
        {
            InitializeComponent();
            VideoRentedView.DataBindingComplete += VideoRentedView_DataBindingComplete;
            LoadVideosRented();

        }
        private void LoadVideosRented()
        {
            UpdateAllOverdueFees();
            using (var context = new AppDbContext())
            {
                var rent = context.Rent.Select(r => new
                {
                    r.VideoID,
                    r.VideoTitle,
                    r.VideoCategory,
                    r.RentDays,
                    r.OverdueFee,
                    r.Total,
                    r.RentDate,
                    r.ReturnDate,
                    r.Status
                }).ToList();

                VideoRentedView.DataSource = rent;
                SetVideoColumnHeader();
            }
        }
        private void SetVideoColumnHeader()
        {
            VideoRentedView.Columns["VideoID"].HeaderText = "Video ID ";
            VideoRentedView.Columns["VideoTitle"].HeaderText = "Title";
            VideoRentedView.Columns["VideoCategory"].HeaderText = "Category";
            VideoRentedView.Columns["RentDays"].HeaderText = "Available Stock";
            VideoRentedView.Columns["OverdueFee"].HeaderText = "Overdue Fee";
            VideoRentedView.Columns["Total"].HeaderText = "Total";
            VideoRentedView.Columns["RentDate"].HeaderText = "Rental Date";
            VideoRentedView.Columns["ReturnDate"].HeaderText = "Return Date";
            VideoRentedView.Columns["Status"].HeaderText = "Status";
        }
        public bool CheckAndUpdateOverdueStatus(int rentalId)
        {
            using (var context = new AppDbContext())
            {
                var rentedItem = context.Rent
                    .FirstOrDefault(r => r.ID == rentalId && r.Status != "OVERDUE");

                if (rentedItem == null)
                    return false;

                DateOnly today = DateOnly.FromDateTime(DateTime.Today);

                if (rentedItem.ReturnDate < today)
                {
                    rentedItem.Status = "OVERDUE";
                    context.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public void UpdateAllOverdueFees()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    DateOnly today = DateOnly.FromDateTime(DateTime.Today);

                    var overdueItems = context.Rent
                        .Where(r => r.Status != "OVERDUE" && r.ReturnDate < today)
                        .ToList();

                    foreach (var rentedVideo in overdueItems)
                    {
                        rentedVideo.Status = "OVERDUE";

                        int daysOverdue = today.DayNumber - rentedVideo.ReturnDate.DayNumber;

                        float fee = daysOverdue * 5f;

                        rentedVideo.Total = fee;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating overdue fees and status: " + ex.Message);
            }
        }

        private void VideoRentedView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            VideoRentedView.ClearSelection();
            VideoRentedView.CurrentCell = null;
        }

        private void VideoRentedView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = VideoRentedView.Rows[e.RowIndex];
                titleTxt.Text = row.Cells["VideoTitle"].Value.ToString();
                feeTxt.Text = row.Cells["OverdueFee"].Value.ToString();
                feeTxt.Text = row.Cells["Total"].Value.ToString();
            }
        }
    }
}
