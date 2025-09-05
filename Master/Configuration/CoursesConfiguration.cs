using Master.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Configuration
{
    internal class CoursesConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasCheckConstraint("Ck_Course_Credits ","Credits > 0");
            builder.HasMany(x=>x.assignments)
                .WithOne(x=>x.Course)
                .HasForeignKey(x=>x.CoursetId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x=>x.exams)
                .WithOne(x=>x.Course)
                .HasForeignKey(x=>x.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x=>x.enrollments)
                .WithOne(x=>x.Course)
                .HasForeignKey(x=>x.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x=>x.courseSchedules)
                .WithOne(x=>x.Course)
                .HasForeignKey(x=>x.CourseId)
                .OnDelete(DeleteBehavior.NoAction);
            
                
        }
    }
}
