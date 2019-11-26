using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WPF_HW5
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-82L5RVF8;Database=ZKHDb;Trusted_Connection=true;");
        }
    }
}
