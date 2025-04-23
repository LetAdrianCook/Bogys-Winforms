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
            CustomerView.DataBindingComplete += CustomerView_DataBindingComplete;
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
                birthDatePicker.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }
            var result = MessageBox.Show("Are you sure you want to edit this customer?",
                                         "Confirm Edit",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int userId = Convert.ToInt32(CustomerView.CurrentRow.Cells["ID"].Value);
                using (var context = new AppDbContext())
                {
                    var customer = context.Users.FirstOrDefault(u => u.ID == userId);
                    if (customer != null)
                    {
                        customer.UserName = usernameTxt.Text;
                        customer.FirstName = firstnameTxt.Text;
                        customer.LastName = lastnameTxt.Text;
                        customer.UserAddress = addressTxt.Text;
                        customer.BirthDate = birthDatePicker.Value;
                        context.SaveChanges();
                    }
                }
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
            if (string.IsNullOrWhiteSpace(usernameTxt.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxt.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(firstnameTxt.Text))
            {
                MessageBox.Show("First name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstnameTxt.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(lastnameTxt.Text))
            {
                MessageBox.Show("Last name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastnameTxt.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(addressTxt.Text))
            {
                MessageBox.Show("Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addressTxt.Focus();
                return false;
            }
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
