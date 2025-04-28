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
                var videos = context.Video.ToList();
                VideoView.DataSource = videos;
            }
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
    }
}
