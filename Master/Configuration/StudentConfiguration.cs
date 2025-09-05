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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasIndex(x=>x.Email).IsUnique();    
            builder.HasMany(x=>x.enrollments)
                .WithOne(x=>x.Student)
                .HasForeignKey(x=>x.StudId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.examResult)
                .WithOne(x => x.Student)
                .HasForeignKey<ExamResult>(x => x.StudId);
            builder.HasMany(x=>x.submissions)
                .WithOne(x=>x.Student)
                .HasForeignKey(x=>x.StudId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x=>x.Bookloans)
                .WithOne(x=>x.Student)
                .HasForeignKey(x=>x.StudId)
                .OnDelete(DeleteBehavior.NoAction);
        
        }
    }
}
