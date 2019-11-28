using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class DatabaseContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rented> Rented { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DESKTOP-1NL0UKE;Database=exam_database;Trusted_Connection=True;");
        }
    }
}
