using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Models;
using System.Diagnostics;
using ConsoleApp1;

namespace Models
{
    public class MyContext : DbContext
    {
    


        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseStudent> CourseStudents { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CollegeDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasKey(p => p.DepartmentId);

            modelBuilder.Entity<Department>()
                .Property(p => p.DepartmentId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Student>()
                .HasKey(p => p.StudentId);
            modelBuilder.Entity<Student>()
                .Property(p => p.StudentId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Course>()
                .Property(p => p.CourseId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<StudentAddress>()
                .Property(p => p.StudentAddressId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Student>().Property(s => s.Name)
                                           .IsRequired();
            modelBuilder.Entity<StudentAddress>().HasKey(s => s.StudentAddressId);

            modelBuilder.Entity<Course>()
                .HasOne(s => s.Department)
                .WithMany(c => c.Courses);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(s => s.Students);
            modelBuilder.Entity<CourseStudent>()
             .HasOne(t => t.Student)
             .WithMany(t => t.CourseStudent)
             .HasForeignKey(t => t.StudentId);

            modelBuilder.Entity<CourseStudent>()
                        .HasOne(t => t.Course)
                        .WithMany(t => t.CourseStudent)
                        .HasForeignKey(t => t.CourseId);

        }   
                
        }

        

    }

}