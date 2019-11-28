using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet <CyberTruck> cyberTrucks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=DESKTOP-ONL0KNF\ELIRA;Database=Elirak_Exam;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Order>()
            //    .HasKey(t => new { t.Username, t.CyberId });

            //modelBuilder.Entity<Order>()
            //    .HasOne(pt => pt.User)
            //    .WithMany(p => p.orders)
            //    .HasForeignKey(pt => pt.Username);

            //modelBuilder.Entity<Order>()
            //    .HasOne(pt => pt.cyberTruck)
            //    .WithOne(t => t.order)
            //   .HasForeignKey(pt =>pt.CyberId);
        }


    }
}
