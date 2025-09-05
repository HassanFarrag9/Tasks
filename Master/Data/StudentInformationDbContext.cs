using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using Master.Models;

namespace Master.Data
{
    internal class StudentInformationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Student Information System;trusted_connection=true;trustservercertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Assignment> assignments {  get; set; }
        public DbSet<Book>books { get; set; }
        public DbSet<Bookloans> Bookloans { get; set; }
        public DbSet<Classroom>classrooms  { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<CourseSchedule> courseSchedules { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Enrollment> enrollments { get; set; }
        public DbSet<Exam> exams { get; set; }
        public DbSet<ExamResult> examResults { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Library> libraries { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Submission> submissions { get; set; }

    }
}
