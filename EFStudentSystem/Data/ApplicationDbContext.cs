using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFStudentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EFStudentSystem.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Courses> Courses { get; set; }
        public DbSet<HomeWorkSubmissions> HomeWorkSubmissions { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
        public DbSet<Students> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Students>()
                .Property(s => s.Name)
                .HasColumnType("varchar(100)")
                .IsUnicode(true);
                

            modelBuilder.Entity<Students>()
                .Property(s => s.PhoneNumber)
                .HasColumnType("varchar(10)")
                .IsUnicode(false)
                .IsRequired(false);

            modelBuilder.Entity<Courses>()
            .Property(c => c.Description)
            .IsRequired(false);

        }
    }
}
