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
using Bogys_Winforms.Windows.Admin.ModalWindows;
using Bogys_Winforms.Strings;
using Microsoft.Identity.Client;

namespace Bogys_Winforms.Windows.Admin
{
    public partial class VideoLibrary : UserControl
    {
        VideoLibraryFunctions vidLibFunction = new VideoLibraryFunctions();
        InputValidator validator = new InputValidator();
        StringsVariables strTxt = new StringsVariables();
        public VideoLibrary()
        {
            InitializeComponent();
            VideoView.DataBindingComplete += VideoView_DataBindingComplete;
            LoadVideos();
        }
        private void LoadVideos()
        {
            videoTypeCbx.SelectedIndex = 0;
            rentDaysCbx.SelectedIndex = 0;
            VideoView.DataSource = vidLibFunction.GetAllVideos();
            vidLibFunction.HeaderTitle(VideoView);
        }
        private void VideoView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            VideoView.ClearSelection();
            VideoView.CurrentCell = null;
        }
        public void RefreshControl()
        {
            LoadVideos();
            VideoView.DataBindingComplete -= VideoView_DataBindingComplete;
            VideoView.DataBindingComplete += VideoView_DataBindingComplete;
            ClearFields();
            VideoView.ClearSelection();
            VideoView.CurrentCell = null;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;

            var result = MessageBox.Show(strTxt.AddBtnMsg, strTxt.AddBtnMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            int vidPrice = VideoPrice();
            int rentDays = Convert.ToInt32(rentDaysCbx.SelectedItem);
            int inCount = Convert.ToInt32(stockTxt.Text);

            bool success = vidLibFunction.AddVideo(titleTxt.Text, videoTypeCbx.Text,
                                                    vidPrice, rentDays, inCount);
            if (!success)
            {
                MessageBox.Show(strTxt.validateVidTitle, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClearFields();
            LoadVideos();

        }
        private void VideoView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = VideoView.Rows[e.RowIndex];
                titleTxt.Text = row.Cells[strTxt.VideoTitle].Value.ToString();
                stockTxt.Text = row.Cells[strTxt.VideoInCount].Value.ToString();
                rentDaysCbx.Text = row.Cells[strTxt.RentDays].Value.ToString();
                videoTypeCbx.SelectedItem = VideoView.Rows[e.RowIndex].Cells[strTxt.VideoCategory].Value.ToString();
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!CheckID()) return;
            if (!checkInput()) return;

            var result = MessageBox.Show(strTxt.editMsg, strTxt.editMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            int videoId = Convert.ToInt32(VideoView.CurrentRow.Cells[strTxt.ID].Value);
            int vidPrice = VideoPrice();
            int rentDays = Convert.ToInt32(rentDaysCbx.SelectedItem);
            int inCount = Convert.ToInt32(stockTxt.Text);

            bool success = vidLibFunction.EditVideo(videoId, titleTxt.Text,
                                                    videoTypeCbx.Text, inCount,
                                                    rentDays, vidPrice);
            if (success)
            {
                ClearFields();
                LoadVideos();
            }
        }
        private bool checkInput()
        {
            if (!validator.ValidateTextBox(titleTxt, strTxt._VideoTitle)) return false;
            if (string.IsNullOrWhiteSpace(stockTxt.Text))
            {
                MessageBox.Show(strTxt.validateInCount, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stockTxt.Focus();
                return false;
            }
            if (!stockTxt.Text.All(char.IsDigit))
            {
                MessageBox.Show(strTxt.validateInCountData, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                stockTxt.Focus();
                return false;
            }
            return true;
        }
        private int VideoPrice()
        {
            if (videoTypeCbx.Text == strTxt.vcd) return 25;
            if (videoTypeCbx.Text == strTxt.dvd) return 50;          
            return 0;
        }
        private bool CheckID()
        {
            if (VideoView.CurrentRow == null || VideoView.CurrentRow.Cells[strTxt.ID].Value == null)
            {
                MessageBox.Show(strTxt.validateEditDelete, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (!CheckID()) return;

            var result = MessageBox.Show(strTxt.confirmDelete, strTxt.confirmDeleteTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;
    
            int videoId = Convert.ToInt32(VideoView.CurrentRow.Cells[strTxt.ID].Value);
            bool success = vidLibFunction.DeleteVideo(videoId);

            if (success)
            {
                ClearFields();
                LoadVideos();
            }           
        }

    }
}
