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

namespace Bogys_Winforms.Windows.Admin
{
    public partial class VideoList: UserControl
    {
        VideoListFunctions vidListFunction = new VideoListFunctions();
        public VideoList()
        {
            InitializeComponent();
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
            VideoView.DataSource = vidListFunction.GetAllVideosRented();
            vidListFunction.HeaderTitle(VideoView);
        }
      
    }
}
