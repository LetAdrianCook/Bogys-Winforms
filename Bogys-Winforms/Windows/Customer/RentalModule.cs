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
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bogys_Winforms.Windows.Admin
{
    public partial class RentalModule : UserControl
    {
        StringsVariables strTxt = new StringsVariables();
        RentalModuleFunctions rentFunction = new RentalModuleFunctions();
        Receipts rentReceipt = new Receipts();
        private int currentCustomerID;
        public RentalModule(int userID)
        {
            InitializeComponent();
            currentCustomerID = userID;
            videoTypeCbx.SelectedIndex = 0;
            txtUserID.Text = currentCustomerID.ToString();
            LoadVideos();
        }
        private void LoadVideos()
        {
            string titleSearch = searchTitleTxt.Text.Trim();
            string categoryFilter = videoTypeCbx.SelectedItem?.ToString();

            if (categoryFilter == strTxt.all) categoryFilter = null;

            VideoView.DataSource = rentFunction.GetAvailableVideos(titleSearch, categoryFilter);
            rentFunction.HeaderTitle(VideoView);
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
            if (!CheckID()) return;

            var result = MessageBox.Show(strTxt.rentMsg, strTxt.rentMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            int videoId = Convert.ToInt32(VideoView.CurrentRow.Cells[strTxt.ID].Value);
            int rentDays = Convert.ToInt32(VideoView.CurrentRow.Cells[strTxt.RentDays].Value);
            int price = Convert.ToInt32(VideoView.CurrentRow.Cells[strTxt.VideoPrice].Value);
            string category = categoryTxt.Text;
            string title = titleTxt.Text;
            string customerName = rentFunction.GetCustomerName(currentCustomerID);
            DateOnly rentDate = DateOnly.FromDateTime(DateTime.Now);
            DateOnly returnDate = rentDate.AddDays(rentDays);

            bool success = rentFunction.RentVideo(currentCustomerID, videoId, customerName, title,
                                                  category, rentDays, rentDate, returnDate);
            if (!success)
            {
                MessageBox.Show(strTxt.validateRentTitle, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            rentReceipt.PrintReceipt(customerName, videoId, title, category, rentDays, rentDate, returnDate, price);
            ClearFields();
            LoadVideos();
        }
        private void ClearFields()
        {
            titleTxt.Clear();
            categoryTxt.Clear();
            rentDaysTxt.Clear();
            priceTxt.Clear();
        }
        private bool CheckID()
        {
            if (VideoView.CurrentRow == null || VideoView.CurrentRow.Cells[strTxt.ID].Value == null)
            {
                MessageBox.Show(strTxt.rentNoSelect, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void searchTitleTxt_TextChanged(object sender, EventArgs e)
        {
            LoadVideos();
        }
        private void videoTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadVideos();
        }
    }
}
