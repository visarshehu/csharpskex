
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_SK.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ChatRoom> ChatRooms{ get; set; }
        public DbSet<Message>Messages { get; set; }
        public DbSet<User>Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=DESKTOP-D55TDT7;Database=exam127162;Trusted_Connection=True;");
        }

    }
}
