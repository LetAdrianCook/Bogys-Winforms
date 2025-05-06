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

namespace Bogys_Winforms.Windows.Admin
{
    public partial class RentalModule : UserControl
    {
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
            rentalDaysCbx.SelectedIndex = 0;
            using (var context = new AppDbContext())
            {
                var videos = context.Video.Where(v => v.VideoInCount > 0).Select(v => new
                    {
                        v.ID,
                        v.VideoTitle,
                        v.VideoCategory,
                        v.VideoInCount,
                        v.VideoPrice
                    }).ToList();
            
                VideoView.DataSource = videos;
                SetVideoColumnHeader();
            }
        }
        private void SetVideoColumnHeader()
        {
            VideoView.Columns["ID"].HeaderText = "Video ID";
            VideoView.Columns["VideoTitle"].HeaderText = "Title";
            VideoView.Columns["VideoCategory"].HeaderText = "Category";
            VideoView.Columns["VideoInCount"].HeaderText = "Available Stock";
            VideoView.Columns["VideoPrice"].HeaderText = "Rental Price";
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
                titleTxt.Text = row.Cells["VideoTitle"].Value.ToString();
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
                int videoId = Convert.ToInt32(VideoView.CurrentRow.Cells["ID"].Value);
                int rentDays = Convert.ToInt32(rentalDaysCbx.SelectedItem);
                string category = Convert.ToString(VideoView.CurrentRow.Cells["VideoCategory"].Value);
                DateOnly rentDate = DateOnly.FromDateTime(DateTime.Now);
                DateOnly returnDate = rentDate.AddDays(Convert.ToInt32(rentalDaysCbx.SelectedItem));

                var newVideoRent = new Rent
                {
                    UserID = currentCustomerID,
                    VideoID = videoId,
                    VideoTitle = titleTxt.Text,
                    VideoCategory = category,
                    RentDays = rentDays,
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
