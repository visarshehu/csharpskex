using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users;
        public DbSet<Car> Cars;
        public DbSet<Rented> Renteds;

        public object Rented { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=DESKTOP-2SUNGKR\SQLEXPRESS;Database=exam;Trusted_Connection=True;");
        }

    }
}
