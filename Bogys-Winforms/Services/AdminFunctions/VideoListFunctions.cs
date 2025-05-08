using Bogys_Winforms.Models;
using Bogys_Winforms.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Services.AdminFunctions
{
    class VideoListFunctions
    {
        StringsVariables strTxt = new StringsVariables();
        public List<Rent> GetAllVideosRented()
        {
            using (var context = new AppDbContext())
            {
                return context.Rent.ToList();
            }
        }
        public void HeaderTitle(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dataGridView.Columns[strTxt.ID].Visible = false;
            dataGridView.Columns[strTxt.VideoID].Visible = false;
            dataGridView.Columns[strTxt.UserID].Visible = false;
            dataGridView.Columns[strTxt.VideoTitle].HeaderText = strTxt._VideoTitle;
            dataGridView.Columns[strTxt.CustomerName].HeaderText = strTxt._CustomerName;
            dataGridView.Columns[strTxt.VideoCategory].HeaderText = strTxt._VideoCategory;
            dataGridView.Columns[strTxt.RentDays].HeaderText = strTxt._RentDays;
            dataGridView.Columns[strTxt.OverdueFee].HeaderText = strTxt._OverdueFee;
            dataGridView.Columns[strTxt.RentDate].HeaderText = strTxt._RentDate;
            dataGridView.Columns[strTxt.ReturnDate].HeaderText = strTxt._ReturnDate;
            dataGridView.Columns[strTxt.Status].HeaderText = strTxt._Status;
        }
    }
}
