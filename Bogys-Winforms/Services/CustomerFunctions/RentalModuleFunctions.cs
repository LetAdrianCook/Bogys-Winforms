using Bogys_Winforms.Models;
using Bogys_Winforms.Strings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Services.CustomerFunctions
{
    class RentalModuleFunctions
    {
        StringsVariables strTxt = new StringsVariables();
        public List<Video> GetAvailableVideos()
        {
            using (var context = new AppDbContext())
            {
                return context.Video.Where(v => v.VideoInCount > 0).ToList();
            }
        }
        public void HeaderTitle(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dataGridView.Columns[strTxt.ID].Visible = false;
            dataGridView.Columns[strTxt.VideoTitle].HeaderText = strTxt._VideoTitle;
            dataGridView.Columns[strTxt.VideoCategory].HeaderText = strTxt._VideoCategory;
            dataGridView.Columns[strTxt.RentDays].HeaderText = strTxt._RentDays;
            dataGridView.Columns[strTxt.VideoInCount].HeaderText = strTxt._VideoInCount;
            dataGridView.Columns[strTxt.VideoOutCount].HeaderText = strTxt._VideoOutCount;
            dataGridView.Columns[strTxt.VideoPrice].HeaderText = strTxt._VideoPrice;
            dataGridView.Columns[strTxt.VideoAdded].HeaderText = strTxt._VideoAdded;
        }
    }
}
