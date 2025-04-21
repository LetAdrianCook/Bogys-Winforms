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

namespace Bogys_Winforms.Windows.Admin
{
    public partial class CustomerLibrary : UserControl
    {
        public CustomerLibrary()
        {
            InitializeComponent();
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            using (var context = new AppDbContext())
            {
                var customers = context.Users.ToList();
                CustomerView.DataSource = customers;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
          
        
        }

    }
}
