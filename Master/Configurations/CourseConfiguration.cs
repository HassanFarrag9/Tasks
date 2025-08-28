using Master.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.HasOne(c => c.Topic)
                   .WithMany(t => t.Courses)
                   .HasForeignKey(c => c.Top_ID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
