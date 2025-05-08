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

namespace Bogys_Winforms.Windows.Admin
{
    public partial class VideoReport: Form
    {
        StringsVariables strTxt = new StringsVariables();
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        
        public VideoReport(object dataSource)
        {
            InitializeComponent();
            reportView.SelectionChanged += (s, e) => reportView.ClearSelection();
            reportView.DataSource = dataSource;
            string todayString = today.ToString();
            dateTxt.TabStop = false;
            dateTxt.Text = todayString;
            HeaderTitle();
        }
        public void HeaderTitle()
        {
            reportView.RowHeadersVisible = false;
            reportView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            reportView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            reportView.ColumnHeadersDefaultCellStyle.Font = new Font(reportView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            reportView.Columns[strTxt.ID].Visible = false;
            reportView.Columns[strTxt.VideoTitle].HeaderText = strTxt._VideoTitle;
            reportView.Columns[strTxt.VideoCategory].HeaderText = strTxt._VideoCategory;
            reportView.Columns[strTxt.RentDays].Visible = false;
            reportView.Columns[strTxt.VideoInCount].HeaderText = strTxt._VideoInCount;
            reportView.Columns[strTxt.VideoOutCount].HeaderText = strTxt._VideoOutCount;
            reportView.Columns[strTxt.VideoPrice].Visible = false;
            reportView.Columns[strTxt.VideoAdded].Visible = false;
        }
    }
}
