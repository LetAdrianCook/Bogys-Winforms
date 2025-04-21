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

                // Authenticate user
                var user = context.Users
                    .FirstOrDefault(u => u.UserName == username && u.UserPassword == password);

                if (user != null)
                {
                    if (user.UserType == "ADMIN")
                    {
                        var adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                    }
                    else if (user.UserType == "CLIENT")
                    {
                        var clientDashboard = new AdminDashboard();
                        clientDashboard.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
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
