using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp3.Models
{
    public partial class studentContext : DbContext
    {
        public studentContext()
        {
        }

        public studentContext(DbContextOptions<studentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accdet> Accdet { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<College> College { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Staffdet> Staffdet { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-SJNJ9181\\SQLEXPRESS;Initial Catalog=student;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accdet>(entity =>
            {
                entity.HasKey(e => new { e.Accno, e.Regno })
                    .HasName("PK__accdet__B5F6313C09A4F612");

                entity.ToTable("accdet");

                entity.Property(e => e.Accno).HasColumnName("accno");

                entity.Property(e => e.Regno).HasColumnName("regno");

                entity.Property(e => e.Ahname)
                    .HasColumnName("ahname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Damount).HasColumnType("money");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("category");

                entity.HasIndex(e => e.Cid)
                    .HasName("UQ__category__D837D05E50958DC2")
                    .IsUnique();

                entity.Property(e => e.Cdesc)
                    .HasColumnName("cdesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<College>(entity =>
            {
                entity.HasKey(e => e.Strollno)
                    .HasName("PK__college__12EFEDA481315523");

                entity.ToTable("college");

                entity.Property(e => e.Strollno)
                    .HasColumnName("strollno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Feeamount)
                    .HasColumnName("feeamount")
                    .HasColumnType("money");

                entity.Property(e => e.Stmailid)
                    .HasColumnName("stmailid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stname)
                    .HasColumnName("stname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__Dept__D877D216D2D42491");

                entity.Property(e => e.Did)
                    .HasColumnName("did")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dlocation)
                    .HasColumnName("dlocation")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dname)
                    .HasColumnName("dname")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__employee__D9509F6D0D813B68");

                entity.ToTable("employee");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Edesig)
                    .HasColumnName("edesig")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Esal)
                    .HasColumnName("esal")
                    .HasColumnType("money");

                entity.HasOne(d => d.D)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.Did)
                    .HasConstraintName("FK__employee__did__36B12243");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("member");

                entity.Property(e => e.Mname)
                    .HasColumnName("mname")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__person__DD37D91ABBEA51F8");

                entity.ToTable("person");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.PGender)
                    .HasColumnName("P_gender")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__product__D837D05FC8A240CD");

                entity.ToTable("product");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pprice)
                    .HasColumnName("pprice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.Rollno)
                    .HasName("PK__school__FABA8B5B44B5256A");

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

            modelBuilder.Entity<Staffdet>(entity =>
            {
                entity.HasKey(e => e.Stid)
                    .HasName("PK__staffdet__312D1FC73A75A4F2");

                entity.ToTable("staffdet");

                entity.Property(e => e.Stid)
                    .HasColumnName("stid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Scontactno).HasColumnName("scontactno");

                entity.Property(e => e.Smailid)
                    .HasColumnName("smailid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sname)
                    .HasColumnName("sname")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.Feeamount)
                    .HasColumnName("feeamount")
                    .HasColumnType("money");

                entity.Property(e => e.Stmailid)
                    .HasColumnName("stmailid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stname)
                    .HasColumnName("stname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Strollno).HasColumnName("strollno");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.Strollno)
                    .HasName("PK__students__12EFEDA40CA48C3D");

                entity.ToTable("students");

                entity.Property(e => e.Strollno)
                    .HasColumnName("strollno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Feeamount)
                    .HasColumnName("feeamount")
                    .HasColumnType("money");

                entity.Property(e => e.Stname)
                    .HasColumnName("stname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
