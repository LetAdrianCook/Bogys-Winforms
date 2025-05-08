using Bogys_Winforms.Strings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Bogys_Winforms.Windows.Admin
{
    public partial class RentalReport: Form
    {
        StringsVariables strTxt = new StringsVariables();
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        public RentalReport(object dataSource)
        {
            InitializeComponent();
            reportView.SelectionChanged += (s, e) => reportView.ClearSelection();
            reportView.DataSource = dataSource;
            string todayString = today.ToString();
            dateTxt.TabStop = false;
            dateTxt.Text = todayString;
            HeaderTitle(reportView);
        }
        public void HeaderTitle(DataGridView dataGridView)
        {
            reportView.RowHeadersVisible = false;
            reportView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            reportView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            reportView.ColumnHeadersDefaultCellStyle.Font = new Font(reportView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            reportView.Columns[strTxt.ID].Visible = false;
            reportView.Columns[strTxt.VideoID].Visible = false;
            reportView.Columns[strTxt.UserID].Visible = false;
            reportView.Columns[strTxt.VideoTitle].HeaderText = strTxt._VideoTitle;
            reportView.Columns[strTxt.CustomerName].HeaderText = strTxt._CustomerName;
            reportView.Columns[strTxt.VideoCategory].HeaderText = strTxt._VideoCategory;
            reportView.Columns[strTxt.RentDays].HeaderText = strTxt._RentDays;
            reportView.Columns[strTxt.OverdueFee].HeaderText = strTxt._OverdueFee;
            reportView.Columns[strTxt.RentDate].HeaderText = strTxt._RentDate;
            reportView.Columns[strTxt.ReturnDate].HeaderText = strTxt._ReturnDate;
            reportView.Columns[strTxt.Status].HeaderText = strTxt._Status;
        }
    }
}
