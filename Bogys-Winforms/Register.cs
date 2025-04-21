using Bogys_Winforms.Models;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginPage = new Login();
            loginPage.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTxt.Text) ||
             string.IsNullOrWhiteSpace(passwordTxt.Text) ||
             string.IsNullOrWhiteSpace(confirmpassTxt.Text) ||
             string.IsNullOrWhiteSpace(addressTxt.Text) ||
             string.IsNullOrWhiteSpace(birthDatePicker.Text) ||
             string.IsNullOrWhiteSpace(firstnameTxt.Text) ||
             string.IsNullOrWhiteSpace(lastnameTxt.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (passwordTxt.Text != confirmpassTxt.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.");
                confirmpassTxt.Focus();
                return;
            }

            var newUser = new Users 
            {
                UserName = usernameTxt.Text.Trim(),
                UserPassword = passwordTxt.Text, 
                UserAddress = addressTxt.Text.Trim(),
                UserType = "CLIENT", 
                BirthDate = birthDatePicker.Value.Date,
                FirstName = firstnameTxt.Text.Trim(),
                LastName = lastnameTxt.Text.Trim(),
                CreatedAt = DateTime.Now
            };

            try
            {
                using (var context = new AppDbContext())
                {
                    context.Users.Add(newUser);
                    context.SaveChanges();
                }

                MessageBox.Show("Registration successful!");
                var loginPage = new Login();
                loginPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user: " + ex.Message);
            }
        }
    }
}

