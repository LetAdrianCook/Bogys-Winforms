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

namespace Bogys_Winforms.Windows.Admin
{
    public partial class VideoLibrary : UserControl
    {
        public VideoLibrary()
        {
            InitializeComponent();
            VideoView.DataBindingComplete += VideoView_DataBindingComplete;
            LoadVideos();
            videoTypeCbx.SelectedIndex = 0;
        }
        private void LoadVideos()
        {
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
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTxt.Text)) 
            {
                MessageBox.Show("Please fill in the Video Title.");
                return;
            }


        }
    }
}
