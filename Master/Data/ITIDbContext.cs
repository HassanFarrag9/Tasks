using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using Master.Models;
using Master.Configuration;

namespace Master.Data
{
    internal class ITIDbContext:DbContext 
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            
        }
        public DbSet<Instructor> Instructores {  get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_inst> Courses_insts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Stud_Course> Studs_Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }

    }
}
