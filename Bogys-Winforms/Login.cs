using Bogys_Winforms.Services;
using Bogys_Winforms.Strings;
using Bogys_Winforms.Windows.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bogys_Winforms
{
    public partial class Login : Form
    {
        StringsVariables strTxt = new StringsVariables();
        public Login()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string username = usernameTxt.Text;
                string password = passwordTxt.Text;

                var user = context.Users
                    .FirstOrDefault(u => u.UserName == username && u.UserPassword == password);

                if (user != null)
                {
                    if (user.UserType == strTxt.AdminType)
                    {
                        var adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                    }
                    else if (user.UserType == strTxt.ClientType)
                    {
                        var clientDashboard = new CustomerDashboard(user.ID);
                        clientDashboard.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(strTxt.invalidUser);
                }
            }

        }
        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerPage = new Register();
            registerPage.Show();
            this.Hide();
        }
    }
}
