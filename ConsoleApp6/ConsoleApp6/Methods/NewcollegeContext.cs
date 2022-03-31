using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp6.Methods
{
    public class NewcollegeContext:DbContext
    {
        public NewcollegeContext():base()
        {

        }
        public NewcollegeContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<student> student { get; set; }
        public DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-SJNJ9181\\SQLEXPRESS;Initial Catalog=NewCollege;Integrated Security=True");
        }
    }
}
