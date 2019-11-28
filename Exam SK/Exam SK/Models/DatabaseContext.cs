using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{

    public class DatabaseContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<ChatRoom> ChatRoom { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=Db02;Database=127316Ex1;Trusted_Connection=True;");
        }

    }
}
