using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class student2Context : DbContext
    {
        public student2Context()
        {
        }

        public student2Context(DbContextOptions<student2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<School> School { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-SJNJ9181\\SQLEXPRESS;Initial Catalog=student2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.Rollno)
                    .HasName("PK__school__FABA8B5BBAE50C2E");

                entity.ToTable("school");

                entity.Property(e => e.Rollno)
                    .HasColumnName("rollno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Stmailid)
                    .HasColumnName("stmailid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stname)
                    .HasColumnName("stname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sublikes)
                    .HasColumnName("sublikes")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
