﻿using Bogys_Winforms.Models;
using Bogys_Winforms.Services;
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

namespace Bogys_Winforms
{
    public partial class Register : Form
    {
        StringsVariables strTxt = new StringsVariables();
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
                string.IsNullOrWhiteSpace(emailTxt.Text) ||
                string.IsNullOrWhiteSpace(phoneTxt.Text) ||
                string.IsNullOrWhiteSpace(firstnameTxt.Text) ||
                string.IsNullOrWhiteSpace(lastnameTxt.Text))
            {
                MessageBox.Show(strTxt.fillReqFields, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordTxt.Text != confirmpassTxt.Text)
            {
                MessageBox.Show(strTxt.confirmPass, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                confirmpassTxt.Focus();
                return;
            }

            string phone = phoneTxt.Text.Trim();
            if (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show(strTxt.validatePhoneMsg, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTxt.Focus();
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    bool usernameExists = context.Users.Any(u => u.UserName.ToLower() == usernameTxt.Text.Trim().ToLower());
                    if (usernameExists)
                    {
                        MessageBox.Show(strTxt.usernameExist, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usernameTxt.Focus();
                        return;
                    }

                    var newUser = new Users
                    {
                        UserName = usernameTxt.Text.Trim(),
                        UserPassword = passwordTxt.Text,
                        UserAddress = addressTxt.Text.Trim(),
                        Email = emailTxt.Text.Trim(),
                        Phonenumber = phone,
                        UserType = strTxt.ClientType,
                        BirthDate = DateOnly.FromDateTime(birthDatePicker.Value),
                        FirstName = firstnameTxt.Text.Trim(),
                        LastName = lastnameTxt.Text.Trim(),
                        CreatedAt = DateTime.Now
                    };

                    context.Users.Add(newUser);
                    context.SaveChanges();
                }

                MessageBox.Show(strTxt.registerSuccess, strTxt.successTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                var loginPage = new Login();
                loginPage.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(strTxt.errorRegister + ex.Message, strTxt.databaseTitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

