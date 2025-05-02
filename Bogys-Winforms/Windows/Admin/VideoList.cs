using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bogys_Winforms.Windows.Admin
{
    public partial class VideoList: UserControl
    {
        public VideoList()
        {
            InitializeComponent();
            LoadVideosRented();
        }
        private void LoadVideosRented()
        {
            using (var context = new AppDbContext())
            {
                var rent = context.Rent.Select(r => new
                {
                    r.UserID,
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

                VideoView.DataSource = rent;
                SetVideoColumnHeader();
            }
        }
        private void SetVideoColumnHeader()
        {
            VideoView.Columns["UserID"].HeaderText = "User ID";
            VideoView.Columns["VideoID"].HeaderText = "Video ID ";
            VideoView.Columns["VideoTitle"].HeaderText = "Title";
            VideoView.Columns["VideoCategory"].HeaderText = "Category";
            VideoView.Columns["RentDays"].HeaderText = "Available Stock";
            VideoView.Columns["OverdueFee"].HeaderText = "Overdue Fee";
            VideoView.Columns["Total"].HeaderText = "Total";
            VideoView.Columns["RentDate"].HeaderText = "Rental Date";
            VideoView.Columns["ReturnDate"].HeaderText = "Return Date";
            VideoView.Columns["Status"].HeaderText = "Status";
        }
    }
}
