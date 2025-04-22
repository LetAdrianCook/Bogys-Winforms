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
        }
        private void LoadVideos()
        {
            videoTypeCbx.SelectedIndex = 0;
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
            if (!checkInput())
            {
                return;
            }
            var result = MessageBox.Show("Are you sure you want to Add this Video?",
                                        "Confirm Add",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                var newVideo = new Video
                {
                    VideoTitle = titleTxt.Text.Trim(),
                    VideoCategory = videoTypeCbx.Text,
                    VideoInCount = 0,
                    VideoOutCount = 0,
                    VideoAdded = DateTime.Now
                };

                try
                {
                    using (var context = new AppDbContext())
                    {
                        context.Video.Add(newVideo);
                        context.SaveChanges();
                    }
                    ClearFields();
                    LoadVideos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving user: " + ex.Message);
                }
            }
        }
        private bool checkInput()
        {

            if (VideoView.CurrentRow == null || VideoView.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Please select a customer to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(titleTxt.Text))
            {
                MessageBox.Show("Video Title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                titleTxt.Focus();
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            titleTxt.Clear();
        }
        private void VideoView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = VideoView.Rows[e.RowIndex];
                titleTxt.Text = row.Cells["VideoTitle"].Value.ToString();
                videoTypeCbx.SelectedItem = VideoView.Rows[e.RowIndex].Cells["VideoCategory"].Value.ToString();
            }
        }
    }
}
