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

namespace Bogys_Winforms.Windows.Admin
{
    public partial class VideoList : UserControl
    {
        VideoListFunctions vidListFunction = new VideoListFunctions();
        StringsVariables strTxt = new StringsVariables();
        public VideoList()
        {
            InitializeComponent();
            videoTypeCbx.SelectedIndex = 0;
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
            string titleSearch = searchTitleTxt.Text.Trim();
            string usernameSearch = searchNameTxt.Text.Trim();
            string categoryFilter = videoTypeCbx.SelectedItem?.ToString();

            if (categoryFilter == strTxt.all) categoryFilter = null;

            VideoView.DataSource = vidListFunction.GetAllVideosRented(titleSearch, usernameSearch, categoryFilter);
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
    }
}
