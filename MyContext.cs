using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Models;
using System.Diagnostics;




namespace Models
{
    public class MyContext : DbContext
    {
    


        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        //public virtual DbSet<StudentAddress> StudentAddresses { get; set; }



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
            modelBuilder.Entity<StudentAddress>().HasKey(s=>s.StudentAddressId);
          
            modelBuilder.Entity<Course>()
                .HasOne(s => s.Department)
                .WithMany(c => c.Courses);
                
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(s => s.Students);
                
                
        }

        //    modelBuilder.Entity<Course>()
        //        .HasOne(c => c.Student)
        //        .WithMany(s => s.Courses)
        //        .HasForeignKey(f => f.CurrentStudentId);
        //    modelBuilder.Entity<Student>()
        //        .HasMany(d => d.Courses)
        //        .WithOne(s => s.Student)
        //        .HasForeignKey(s=>s.CurrentStudentId);
        //         
        //        
        //        
        //    modelBuilder.Entity<Department>()
        //        .HasKey(x => x.Id);
        //    modelBuilder.Entity<Department>()
        //        .Property(x => x.Id)
        //        .HasColumnOrder(0)
        //        .ValueGeneratedNever();
        //    modelBuilder.Entity<Department>()
        //        .Property(x => x.Name)
        //        .HasColumnOrder(1);
        //
        //    modelBuilder.Entity<Employee>()
        //        .Property(x => x.Id)
        //        .HasColumnOrder(0)
        //        .ValueGeneratedNever();
        //    modelBuilder.Entity<Employee>()
        //        .Property(x => x.Name)
        //        .HasColumnOrder(1)
        //        .IsRequired();
        //    modelBuilder.Entity<Employee>()
        //        .Property(x => x.Salary)
        //        .HasDefaultValue(1000);
        //    modelBuilder.Entity<Employee>()
        //        .Property(p=>p.Department)
        //        .IsRequired(p => p.Department)
        //        .WithMany().Map(x => x.MapKey("DepartmentId"))
        //        .HasForeignKey(p => p.AuthorFK);
        //
        //
        //
        //}


    }

}