using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace ConsoleApp5.Models
{
    public class CollegeContext:DbContext
    {
        public CollegeContext():base()
        {

        }
        public CollegeContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<student> student { get; set; }
        public DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-SJNJ9181\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
        }
    }
}
