using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bogys_Winforms.Services;

namespace Bogys_Winforms.Windows.Customer
{
    public partial class ReturnModule : UserControl
    {
        private int currentCustomerID;
        public ReturnModule(int userID)
        {
            InitializeComponent();
            currentCustomerID = userID;
            VideoRentedView.DataBindingComplete += VideoRentedView_DataBindingComplete;
            LoadVideosRented();
        }
        private void ReturnModule_Load(object sender, EventArgs e)
        {
            LoadVideosRented();
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
            }
        }
        public void LoadVideosRented()
        {
            UpdateAllOverdueFees();
            using (var context = new AppDbContext())
            {
                var rent = context.Rent
                .Where(r => r.UserID == currentCustomerID).Select(r => new
                {
                    r.ID,
                    r.VideoID,
                    r.VideoTitle,
                    r.VideoCategory,
                    r.OverdueFee,
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
            VideoRentedView.Columns["ID"].HeaderText = "Rent ID ";
            VideoRentedView.Columns["VideoID"].HeaderText = "Video ID ";
            VideoRentedView.Columns["VideoTitle"].HeaderText = "Title";
            VideoRentedView.Columns["VideoCategory"].HeaderText = "Category";
            //VideoRentedView.Columns["RentDays"].HeaderText = "Day(s) Rented";
            VideoRentedView.Columns["OverdueFee"].HeaderText = "Overdue Fee";
            VideoRentedView.Columns["RentDate"].HeaderText = "Rental Date";
            VideoRentedView.Columns["ReturnDate"].HeaderText = "Return Date";
            VideoRentedView.Columns["Status"].HeaderText = "Status";
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
                        if (rentedVideo.Status != "OVERDUE")
                        {
                            rentedVideo.Status = "OVERDUE";
                        }

                        int daysOverdue = today.DayNumber - rentedVideo.ReturnDate.DayNumber;

                        float fee = daysOverdue * 5f;

                        rentedVideo.OverdueFee = fee;
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating overdue fees and status: " + ex.Message);
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            // Get rental ID from grid (adjust column name if needed)
            var selectedRow = VideoRentedView.CurrentRow;
            int rentalId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            string overdueFeeTxt = Convert.ToString(selectedRow.Cells["OverdueFee"].Value);

            if (VideoRentedView.CurrentRow == null)
            {
                MessageBox.Show("Please select a video to return");
                return;
            }

            var confirmResult = MessageBox.Show(
                "Are you sure you want to return this movie? with overdue fee of " + overdueFeeTxt ,
                "Confirm Return",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }



            try
            {
                bool success = ReturnMovie(rentalId);

                if (success)
                {
                    LoadVideosRented();
                    MessageBox.Show("Video returned successfully!");
                }
                else
                {
                    MessageBox.Show("Return failed: Rental or video not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning movie: {ex.Message}");
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
                        var rentedMovie = context.Rent
                            .FirstOrDefault(r => r.ID == rentalId);

                        if (rentedMovie == null) return false;

                        var video = context.Video
                            .FirstOrDefault(v => v.ID == rentedMovie.VideoID);

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
