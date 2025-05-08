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
using Bogys_Winforms.Services.AdminFunctions;
using Bogys_Winforms.Services;
using Bogys_Winforms.Strings;

namespace Bogys_Winforms.Windows.Admin
{
    public partial class CustomerLibrary : UserControl
    {
        CustomerLibraryFunctions customerFunction = new CustomerLibraryFunctions();
        InputValidator validator = new InputValidator();
        StringsVariables strTxt = new StringsVariables();

        public CustomerLibrary()
        {
            InitializeComponent();
            CustomerView.DataBindingComplete += CustomerView_DataBindingComplete;
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            string usernameSearch = searchuserTxt.Text.Trim();
            string firstnameSearch = searchFirstTxt.Text.Trim();
            string lastNameSearch = searchLastTxt.Text.Trim();

            CustomerView.DataSource = customerFunction.GetAllCustomers(usernameSearch, firstnameSearch, lastNameSearch);
            customerFunction.HeaderTitle(CustomerView);
        }
        private void CustomerView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomerView.ClearSelection();
            CustomerView.CurrentCell = null;
        }
        public void RefreshControl()
        {
            LoadCustomer();
            CustomerView.DataBindingComplete -= CustomerView_DataBindingComplete;
            CustomerView.DataBindingComplete += CustomerView_DataBindingComplete;
            clearFields();
            CustomerView.ClearSelection();
            CustomerView.CurrentCell = null;
        }
        private void CustomerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CustomerView.Rows[e.RowIndex];
                usernameTxt.Text = row.Cells[strTxt.UserName].Value.ToString();
                firstnameTxt.Text = row.Cells[strTxt.FirstName].Value.ToString();
                lastnameTxt.Text = row.Cells[strTxt.LastName].Value.ToString();
                addressTxt.Text = row.Cells[strTxt.UserAddress].Value.ToString();
                emailTxt.Text = row.Cells[strTxt.Email].Value.ToString();
                phoneTxt.Text = row.Cells[strTxt.Phonenumber].Value.ToString();
                birthDatePicker.Value = ((DateOnly)row.Cells[strTxt.BirthDate].Value).ToDateTime(TimeOnly.MinValue);
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;

            var result = MessageBox.Show(strTxt.editMsg, strTxt.editMsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            int customerId = Convert.ToInt32(CustomerView.CurrentRow.Cells[strTxt.ID].Value);
            DateOnly birthDate = DateOnly.FromDateTime(birthDatePicker.Value);

            bool success = customerFunction.EditCustomer(customerId, usernameTxt.Text,
                                                         firstnameTxt.Text, lastnameTxt.Text,
                                                         addressTxt.Text, emailTxt.Text, phoneTxt.Text,
                                                         birthDate);
            if (success)
            {
                clearFields();
                LoadCustomer();
            }
        }
        private void clearFields()
        {
            usernameTxt.Clear();
            firstnameTxt.Clear();
            lastnameTxt.Clear();
            addressTxt.Clear();
            emailTxt.Clear();
            phoneTxt.Clear();
            birthDatePicker.Value = DateTime.Today;
        }
        private bool checkInput()
        {
            if (CustomerView.CurrentRow == null || CustomerView.CurrentRow.Cells[strTxt.ID].Value == null)
            {
                MessageBox.Show(strTxt.customerSelect, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!validator.ValidateTextBox(usernameTxt, strTxt._UserName)) return false;
            if (!validator.ValidateTextBox(firstnameTxt, strTxt._FirstName)) return false;
            if (!validator.ValidateTextBox(lastnameTxt, strTxt._LastName)) return false;
            if (!validator.ValidateTextBox(addressTxt, strTxt._UserAddress)) return false;
            if (!validator.ValidateTextBox(emailTxt, strTxt._Email)) return false;
            string phone = phoneTxt.Text.Trim();
            if (phone.Length != 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show(strTxt.validatePhoneMsg, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneTxt.Focus();
                return false;
            }
            if (birthDatePicker.Value.Date > DateTime.Today)
            {
                MessageBox.Show(strTxt.validateBday, strTxt.validationTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                birthDatePicker.Focus();
                return false;
            }
            return true;
        }
        private void searchuserTxt_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        private void searchFirstTxt_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }
        private void searchLastTxt_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer();
        }
    }
}