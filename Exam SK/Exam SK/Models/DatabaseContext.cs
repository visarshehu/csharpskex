using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet <Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ChatRoom> ChatRooms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=db02;Database=zi27281ex1;Trusted_Connection=True;");
        }

    }
}
