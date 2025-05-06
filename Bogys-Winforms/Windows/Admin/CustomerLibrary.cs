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

namespace Bogys_Winforms.Windows.Admin
{
    public partial class CustomerLibrary : UserControl
    {
        CustomerLibraryFunctions customerFunction = new CustomerLibraryFunctions();
        public CustomerLibrary()
        {
            InitializeComponent();
            CustomerView.DataBindingComplete += CustomerView_DataBindingComplete;
            LoadCustomer();
        }
        private void LoadCustomer()
        {
            CustomerView.DataSource = customerFunction.GetAllCustomers();
            customerFunction.HeaderTitle(CustomerView);
        }
        private void CustomerView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CustomerView.ClearSelection();
            CustomerView.CurrentCell = null;
        }
        private void CustomerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = CustomerView.Rows[e.RowIndex];
                usernameTxt.Text = row.Cells["UserName"].Value.ToString();
                firstnameTxt.Text = row.Cells["FirstName"].Value.ToString();
                lastnameTxt.Text = row.Cells["LastName"].Value.ToString();
                addressTxt.Text = row.Cells["UserAddress"].Value.ToString();
                birthDatePicker.Value = ((DateOnly)row.Cells["BirthDate"].Value).ToDateTime(TimeOnly.MinValue);
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;

            var result = MessageBox.Show("Are you sure you want to edit this customer?","Confirm Edit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            int customerId = Convert.ToInt32(CustomerView.CurrentRow.Cells["ID"].Value);
            DateOnly birthDate = DateOnly.FromDateTime(birthDatePicker.Value);

            bool success = customerFunction.EditCustomer(
                customerId,
                usernameTxt.Text,
                firstnameTxt.Text,
                lastnameTxt.Text,
                addressTxt.Text,
                birthDate 
            );

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
            birthDatePicker.Value = DateTime.Today;
        }
        private bool checkInput()
        {
            if (CustomerView.CurrentRow == null || CustomerView.CurrentRow.Cells["Id"].Value == null)
            {
                MessageBox.Show("Please select a customer to edit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!InputValidator.ValidateTextBox(usernameTxt, "Username")) return false;
            if (!InputValidator.ValidateTextBox(firstnameTxt, "First name")) return false;
            if (!InputValidator.ValidateTextBox(lastnameTxt, "Last name")) return false;
            if (!InputValidator.ValidateTextBox(addressTxt, "Address")) return false;
            if (birthDatePicker.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Birthdate cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                birthDatePicker.Focus();
                return false;
            }
            return true;
        }


    }
}
