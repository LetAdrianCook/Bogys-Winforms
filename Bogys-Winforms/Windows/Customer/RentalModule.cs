using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogys_Winforms.Models;
using Bogys_Winforms.Services;
using Bogys_Winforms.Strings;
using Bogys_Winforms.Services.CustomerFunctions;

namespace Bogys_Winforms.Windows.Admin
{
    public partial class RentalModule : UserControl
    {
        StringsVariables strTxt = new StringsVariables();
        RentalModuleFunctions rentFunction = new RentalModuleFunctions();
        private int currentCustomerID;
        public RentalModule(int userID)
        {
            InitializeComponent();
            currentCustomerID = userID;
            txtUserID.Text = currentCustomerID.ToString();
            VideoView.DataBindingComplete += VideoView_DataBindingComplete;
            LoadVideos();
        }
        private void LoadVideos()
        {
            VideoView.DataSource = rentFunction.GetAvailableVideos();
            rentFunction.HeaderTitle(VideoView);
        }
        private void VideoView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            VideoView.ClearSelection();
            VideoView.CurrentCell = null;
        }
        private void VideoView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = VideoView.Rows[e.RowIndex];
                titleTxt.Text = row.Cells[strTxt.VideoTitle].Value.ToString();
                priceTxt.Text = row.Cells[strTxt.VideoPrice].Value.ToString();
                categoryTxt.Text = row.Cells[strTxt.VideoCategory].Value.ToString();
                rentDaysTxt.Text = row.Cells[strTxt.RentDays].Value.ToString();
            }
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to Add this Video?",
                                      "Confirm Add",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int videoId = Convert.ToInt32(VideoView.CurrentRow.Cells[strTxt.ID].Value);
                int rentDays = Convert.ToInt32(VideoView.CurrentRow.Cells[strTxt.RentDays].Value);
                string category = categoryTxt.Text;
                DateOnly rentDate = DateOnly.FromDateTime(DateTime.Now);
                DateOnly returnDate = rentDate.AddDays(rentDays);

                var newVideoRent = new Rent
                {
                    UserID = currentCustomerID,
                    VideoID = videoId,
                    VideoTitle = titleTxt.Text,
                    VideoCategory = category,
                    OverdueFee = 0 ,
                    RentDate = rentDate,
                    ReturnDate = returnDate,
                    Status = "ACTIVE",
                };

                try
                {
                    using (var context = new AppDbContext())
                    {
                        var videos = context.Video.FirstOrDefault(u => u.ID == videoId);
                        if (videos != null)
                        {
                            videos.VideoInCount -= 1;
                            videos.VideoOutCount += 1;

                            context.Rent.Add(newVideoRent);

                            context.SaveChanges();
                        }
                    }
                   
                    LoadVideos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving user: " + ex.Message);
                }
            }
        }
    }
}
