using Bogys_Winforms.Models;
using Bogys_Winforms.Strings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Services.CustomerFunctions
{
    class RentalModuleFunctions
    {
        StringsVariables strTxt = new StringsVariables();
        public List<Video> GetAvailableVideos(string title, string category)
        {
            using (var context = new AppDbContext())
            {
                var query = context.Video.AsQueryable();

                if (!string.IsNullOrEmpty(title)) query = query.Where(r => r.VideoTitle.Contains(title));
                if (!string.IsNullOrEmpty(category)) query = query.Where(r => r.VideoCategory == category);

                return query.Where(v => v.VideoInCount > 0).ToList();
            }
        }
        public void HeaderTitle(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dataGridView.Columns[strTxt.ID].Visible = false;
            dataGridView.Columns[strTxt.VideoTitle].HeaderText = strTxt._VideoTitle;
            dataGridView.Columns[strTxt.VideoCategory].HeaderText = strTxt._VideoCategory;
            dataGridView.Columns[strTxt.RentDays].HeaderText = strTxt._RentDays;
            dataGridView.Columns[strTxt.VideoInCount].HeaderText = strTxt._VideoInCount;
            dataGridView.Columns[strTxt.VideoOutCount].HeaderText = strTxt._VideoOutCount;
            dataGridView.Columns[strTxt.VideoPrice].HeaderText = strTxt._VideoPrice;
            dataGridView.Columns[strTxt.VideoAdded].HeaderText = strTxt._VideoAdded;
        }
        public string GetCustomerName(int userId)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.First(u => u.ID == userId);
                return $"{user.FirstName} {user.LastName}";
            }
        }
        public bool RentVideo(int userID, int videoID, string customerName, string videoTitle,
            string videoCategory, int rentDays, DateOnly rentDate, DateOnly returnDate)
        {
            using (var context = new AppDbContext())
            {
                bool exists = context.Rent.Any(r => r.UserID == userID && r.VideoID == videoID);
                if (exists) return false;

                var videos = context.Video.FirstOrDefault(u => u.ID == videoID);
                if (videos != null)
                {
                    videos.VideoInCount -= 1;
                    videos.VideoOutCount += 1;
                }

                var newVideoRent = new Rent
                {
                    UserID = userID,
                    VideoID = videoID,
                    CustomerName = customerName,
                    VideoTitle = videoTitle,
                    VideoCategory = videoCategory,
                    OverdueFee = 0,
                    RentDays = rentDays,
                    RentDate = rentDate,
                    ReturnDate = returnDate,
                    Status = strTxt.active,
                };

                context.Rent.Add(newVideoRent);
                return context.SaveChanges() > 0;
            }
        }
    }
}
