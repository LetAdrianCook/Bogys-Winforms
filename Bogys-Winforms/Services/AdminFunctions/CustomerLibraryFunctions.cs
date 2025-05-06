using Bogys_Winforms.Models;
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
        public List<Users> GetAllCustomers()
        {
            using (var context = new AppDbContext())
            {
             return context.Users
            .Where(u => u.UserType == "CLIENT")
            .Select(u => new Users
            {
                ID = u.ID,
                UserName = u.UserName,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserAddress = u.UserAddress,
                BirthDate = u.BirthDate,
                CreatedAt = u.CreatedAt
            })
            .ToList();
            }
        }
        public void HeaderTitle(DataGridView dateGridView)
        {
            dateGridView.Columns["ID"].Visible = false;
            dateGridView.Columns["UserName"].HeaderText = "Username ";
            dateGridView.Columns["UserPassword"].Visible = false;
            dateGridView.Columns["UserType"].Visible = false;
            dateGridView.Columns["FirstName"].HeaderText = "First Name";
            dateGridView.Columns["LastName"].HeaderText = "Last Name";
            dateGridView.Columns["UserAddress"].HeaderText = "Address";
            dateGridView.Columns["BirthDate"].HeaderText = "Birth Date";
            dateGridView.Columns["CreatedAt"].HeaderText = "Creation Date";
        }
        public bool EditCustomer(int userId, string username, string firstName,
                             string lastName, string address, DateOnly birthDate)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Users.FirstOrDefault(u => u.ID == userId);
                if (customer == null) return false;

                customer.UserName = username;
                customer.FirstName = firstName;
                customer.LastName = lastName;
                customer.UserAddress = address;
                customer.BirthDate = birthDate;

                context.SaveChanges();
                return true;
            }
        }

    }
}
