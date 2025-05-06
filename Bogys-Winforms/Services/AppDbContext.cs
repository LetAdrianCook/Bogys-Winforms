using Bogys_Winforms.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bogys_Winforms.Models.Users;

namespace Bogys_Winforms.Services
{
    class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Rent> Rent { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-J3KT7FLV;Initial Catalog=BogsyWinforms;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}