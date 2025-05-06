using Bogys_Winforms.Models;
using Bogys_Winforms.Strings;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Services.AdminFunctions
{
    class CustomerLibraryFunctions
    {
        StringsVariables strTxt = new StringsVariables();
        public List<Users> GetAllCustomers()
        {
            using (var context = new AppDbContext())
            {
             return context.Users
            .Where(u => u.UserType == strTxt.ClientType)
            .Select(u => new Users
            {
                ID = u.ID,
                UserName = u.UserName,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserAddress = u.UserAddress,
                Email = u.Email,
                Phonenumber = u.Phonenumber,
                BirthDate = u.BirthDate,
                CreatedAt = u.CreatedAt
            })
            .ToList();
            }
        }
        public void HeaderTitle(DataGridView dataGridView)
        {
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dataGridView.Columns[strTxt.ID].Visible = false;
            dataGridView.Columns[strTxt.UserName].HeaderText = strTxt._UserName;
            dataGridView.Columns[strTxt.UserPassword].Visible = false;
            dataGridView.Columns[strTxt.UserType].Visible = false;
            dataGridView.Columns[strTxt.FirstName].HeaderText = strTxt._FirstName;
            dataGridView.Columns[strTxt.LastName].HeaderText = strTxt._LastName;
            dataGridView.Columns[strTxt.Email].HeaderText = strTxt._Email;
            dataGridView.Columns[strTxt.Phonenumber].HeaderText = strTxt._Phonenumber;
            dataGridView.Columns[strTxt.UserAddress].HeaderText = strTxt._UserAddress;
            dataGridView.Columns[strTxt.BirthDate].HeaderText = strTxt._BirthDate;
            dataGridView.Columns[strTxt.CreatedAt].HeaderText = strTxt._CreatedAt;
        }
        public bool EditCustomer(int userId, string username, string firstName,
                             string lastName, string address, string email, string phonenumber, DateOnly birthDate)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Users.FirstOrDefault(u => u.ID == userId);
                if (customer == null) return false;

                customer.UserName = username;
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.UserAddress = address;
                customer.Email = email;
                customer.Phonenumber = phonenumber;
                customer.BirthDate = birthDate;

                context.SaveChanges();
                return true;
            }
        }

    }
}
