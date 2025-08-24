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
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Duration).HasColumnType("int").IsRequired(true);
            builder.HasCheckConstraint("CK_Duration", "Duration > 0");
            builder.Property(x => x.Name).HasMaxLength(100).HasColumnType("nvarchar").IsRequired(true);
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(x => x.Description).HasMaxLength(255).HasColumnType("nvarchar").IsRequired(false);


        }
    }
}
