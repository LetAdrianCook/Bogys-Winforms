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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Bogys_Winforms.Migrations;
using Bogys_Winforms.Services;
using Bogys_Winforms.Services.AdminFunctions;

namespace Bogys_Winforms.Windows.Admin
{
    public partial class VideoLibrary : UserControl
    {
        VideoLibraryFunctions vidLibFunction = new VideoLibraryFunctions();
        public VideoLibrary()
        {
            InitializeComponent();
            VideoView.DataBindingComplete += VideoView_DataBindingComplete;
            LoadVideos();
            TextFieldControl();
        }
        private void LoadVideos()
        {
            videoTypeCbx.SelectedIndex = 0;
            VideoView.DataSource = vidLibFunction.GetAllVideos();
            vidLibFunction.HeaderTitle(VideoView);
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
                float vidPrice = VideoPrice();
                var newVideo = new Video
                {
                    VideoTitle = titleTxt.Text.Trim(),
                    VideoCategory = videoTypeCbx.Text,
                    VideoPrice = vidPrice,
                    VideoInCount = Convert.ToInt32(stockTxt.Text),
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
                    TextFieldControl();
                    ClearFields();
                    LoadVideos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving user: " + ex.Message);
                }
            }
        }
        private void VideoView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = VideoView.Rows[e.RowIndex];
                titleTxt.Text = row.Cells["VideoTitle"].Value.ToString();
                stockTxt.Text = row.Cells["VideoInCount"].Value.ToString();
                videoTypeCbx.SelectedItem = VideoView.Rows[e.RowIndex].Cells["VideoCategory"].Value.ToString();
                TextFieldControl();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!CheckID()) return;
            if (!checkInput()) return;

            var result = MessageBox.Show("Are you sure you want to edit this Video?",
                                         "Confirm Edit",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int videoId = Convert.ToInt32(VideoView.CurrentRow.Cells["ID"].Value);
                using (var context = new AppDbContext())
                {
                    float vidPrice = VideoPrice();
                    var videos = context.Video.FirstOrDefault(u => u.ID == videoId);
                    if (videos != null)
                    {
                        videos.VideoTitle = titleTxt.Text;
                        videos.VideoCategory = videoTypeCbx.Text;
                        videos.VideoPrice = vidPrice;
                        context.SaveChanges();
                    }
                }
                TextFieldControl();
                ClearFields();
                LoadVideos();
            }
        }
        private bool checkInput()
        {
            if (string.IsNullOrWhiteSpace(titleTxt.Text))
            {
                MessageBox.Show("Video Title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                titleTxt.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(stockTxt.Text))
            {
                MessageBox.Show("Video Title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                titleTxt.Focus();
                return false;
            }
            return true;
        }
        private float VideoPrice()
        {
            if (videoTypeCbx.Text == "VCD")
            {
                return 25;
            }
            if (videoTypeCbx.Text == "DVD")
            {
                return 50;
            }
            return 0;
        }
        private bool CheckID()
        {
            if (VideoView.CurrentRow == null || VideoView.CurrentRow.Cells["ID"].Value == null)
            {
                MessageBox.Show("Please select a Video to edit or delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ClearFields()
        {
            titleTxt.Clear();
            stockTxt.Clear();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!CheckID())
            {
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete this Video?",
                                        "Confirm Edit",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int videoId = Convert.ToInt32(VideoView.CurrentRow.Cells["ID"].Value);
                using (var context = new AppDbContext())
                {
                    var videos = context.Video.FirstOrDefault(u => u.ID == videoId);
                    if (videos != null)
                    {
                        context.Video.Remove(videos);
                        context.SaveChanges();
                    }
                }
                ClearFields();
                TextFieldControl();
                LoadVideos();
            }
        }
        private void TextFieldControl()
        {
            if (VideoView.CurrentRow == null)
            {
                titleTxt.Enabled = false;
                stockTxt.Enabled = false;
                videoTypeCbx.Enabled = false;
               
            }else
            {
                titleTxt.Enabled = true;
                stockTxt.Enabled = true;
                videoTypeCbx.Enabled = true;
            }
               
        }
    }
}
