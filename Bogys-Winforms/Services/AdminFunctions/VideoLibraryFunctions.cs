using Bogys_Winforms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Services.AdminFunctions
{
    class VideoLibraryFunctions
    {
        public List<Video> GetAllVideos()
        {
            using (var context = new AppDbContext())
            {
                return context.Video.ToList();
            }
        }
        public void HeaderTitle(DataGridView dateGridView)
        {
            dateGridView.Columns["ID"].Visible = false;
            dateGridView.Columns["VideoTitle"].HeaderText = "Title ";
            dateGridView.Columns["VideoCategory"].HeaderText = "Category";
            dateGridView.Columns["VideoInCount"].HeaderText = "In";
            dateGridView.Columns["VideoOutCount"].HeaderText = "Out";
            dateGridView.Columns["VideoPrice"].HeaderText = "Rent Price";
            dateGridView.Columns["VideoAdded"].HeaderText = "Video Added";
        }
    }
}
