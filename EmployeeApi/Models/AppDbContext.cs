using Employee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeApi.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Empolyee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Department>(
                b=> {
                    b.HasKey("Id");
                    b.Property(e => e.Id);

                    b.Property(e => e.DepartmentName);
                });
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, DepartmentName = "IT" });

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 2, DepartmentName = "HR" });
            
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 3, DepartmentName = "Payroll" });


            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 4, DepartmentName = "Admin" });

            modelBuilder.Entity<Department>(
                b => {
                    b.HasKey("Id");

                    b.Property(e => e.DepartmentName);
                });

            modelBuilder.Entity<Employee.Models.Empolyee>(
                b => {
                    b.HasKey("Id");
                    b.Property(e => e.Id);
                    b.Property(e => e.DateOfBirth);
                    b.Property(e => e.DeparmentId);
                    b.Property(e => e.Email);
                    b.Property(e => e.FirstName);
                    b.Property(e => e.Gender);
                    b.Property(e => e.LastName);
                    b.Property(e => e.PhotoPath);
                    

                });
           

        }

    }
}
