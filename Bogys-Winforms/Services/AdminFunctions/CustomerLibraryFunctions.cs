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
                return context.Users.ToList();
            }
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
