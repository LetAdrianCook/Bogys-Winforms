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
using Bogys_Winforms.Strings;
using Bogys_Winforms.Services.CustomerFunctions;

namespace Bogys_Winforms.Windows.Customer
{
    public partial class ReturnModule : UserControl
    {
        private int currentCustomerID;
        StringsVariables strTxt = new StringsVariables();
        ReturnModuleFunctions returnModuleFunc = new ReturnModuleFunctions();
        Receipts returnReceipt = new Receipts();
        public ReturnModule(int userID)
        {
            InitializeComponent();
            currentCustomerID = userID;
            VideoRentedView.DataBindingComplete += VideoRentedView_DataBindingComplete;
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
                titleTxt.Text = row.Cells[strTxt.VideoTitle].Value.ToString();
                feeTxt.Text = row.Cells[strTxt.OverdueFee].Value.ToString();
            }
        }
        private void LoadVideosRented()
        {
            returnModuleFunc.UpdateAllOverdueFees();
            VideoRentedView.DataSource = returnModuleFunc.GetCustomerRent(currentCustomerID);
            returnModuleFunc.HeaderTitle(VideoRentedView);
        }
        public void RefreshControl()
        {
            LoadVideosRented();
            VideoRentedView.DataBindingComplete -= VideoRentedView_DataBindingComplete;
            VideoRentedView.DataBindingComplete += VideoRentedView_DataBindingComplete;
            ClearFields();
            VideoRentedView.ClearSelection();
            VideoRentedView.CurrentCell = null;
        }    
        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (!CheckID()) return;

            int rentDays = Convert.ToInt32(VideoRentedView.CurrentRow.Cells[strTxt.RentDays].Value);
            DateOnly rentDate = (DateOnly)VideoRentedView.CurrentRow.Cells[strTxt.RentDate].Value;
            DateOnly returnDate = (DateOnly)VideoRentedView.CurrentRow.Cells[strTxt.ReturnDate].Value;
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
            int rentalId = Convert.ToInt32(VideoRentedView.CurrentRow.Cells[strTxt.ID].Value);
            int videoId = Convert.ToInt32(VideoRentedView.CurrentRow.Cells[strTxt.VideoID].Value);
            int overdueFeeTxt = Convert.ToInt32(VideoRentedView.CurrentRow.Cells[strTxt.OverdueFee].Value);
            string customerName = VideoRentedView.CurrentRow.Cells[strTxt.CustomerName].Value.ToString();
            string title = VideoRentedView.CurrentRow.Cells[strTxt.VideoTitle].Value.ToString();
            string category = VideoRentedView.CurrentRow.Cells[strTxt.VideoCategory].Value.ToString();

            var result = MessageBox.Show(strTxt.validateReturn + overdueFeeTxt, strTxt.validationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            bool success = returnModuleFunc.ReturnMovie(rentalId);

            if (success)
            {
                returnReceipt.PrintReturnReceipt(customerName, videoId, title, category, rentDays, rentDate, returnDate, overdueFeeTxt, currentDate);
                LoadVideosRented();
                ClearFields();
            }
        }
        private void ClearFields()
        {
            titleTxt.Clear();
            feeTxt.Clear();
        }
        private bool CheckID()
        {
            if (VideoRentedView.CurrentRow == null || VideoRentedView.CurrentRow.Cells[strTxt.ID].Value == null)
            {
                MessageBox.Show(strTxt.returnNoSelect, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
