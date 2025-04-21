using Bogys_Winforms.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Repositories
{
    public class UsersRepository
    {
        private readonly string connectionString = "Data Source=LAPTOP-J3KT7FLV;Initial Catalog=BogsyWinforms;Integrated Security=True;Trust Server Certificate=True";
   
        public List<Users> GetUsers()
        {
            var users = new List<Users>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.ToString());
            }

            return users;
        }
    }
}
