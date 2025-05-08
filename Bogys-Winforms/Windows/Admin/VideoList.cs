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
using Bogys_Winforms.Services.AdminFunctions;
using Bogys_Winforms.Strings;
using Bogys_Winforms.Services.CustomerFunctions;

namespace Bogys_Winforms.Windows.Admin
{
    public partial class VideoList : UserControl
    {
        VideoListFunctions vidListFunction = new VideoListFunctions();
        StringsVariables strTxt = new StringsVariables();
        ReturnModuleFunctions updateFees = new ReturnModuleFunctions();
        public VideoList()
        {
            InitializeComponent();
            videoTypeCbx.SelectedIndex = 0;
            statusCbx.SelectedIndex = 0;
            VideoView.SelectionChanged += (s, e) => VideoView.ClearSelection();
            LoadVideosRented();
        }
        public void RefreshControl()
        {
            LoadVideosRented();
            VideoView.ClearSelection();
            VideoView.CurrentCell = null;
        }
        private void LoadVideosRented()
        {
            updateFees.UpdateAllOverdueFees();
            string titleSearch = searchTitleTxt.Text.Trim();
            string usernameSearch = searchNameTxt.Text.Trim();
            string categoryFilter = videoTypeCbx.SelectedItem?.ToString();
            string statusFilter = statusCbx.SelectedItem?.ToString();

            if (categoryFilter == strTxt.all) categoryFilter = null;
            if (statusFilter == strTxt.all) statusFilter = null;

            VideoView.DataSource = vidListFunction.GetAllVideosRented(titleSearch, usernameSearch, categoryFilter, statusFilter);
            vidListFunction.HeaderTitle(VideoView);
        }
        private void searchTitleTxt_TextChanged(object sender, EventArgs e)
        {
            LoadVideosRented();
        }

        private void searchNameTxt_TextChanged(object sender, EventArgs e)
        {
            LoadVideosRented();
        }
        private void videoTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadVideosRented();
        }
        private void statusCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadVideosRented();
        }
        private void reportBtn_Click(object sender, EventArgs e)
        {
            var currentData = VideoView.DataSource;
            RentalReport reportForm = new RentalReport(currentData);
            reportForm.Show();
        }
    }
}
