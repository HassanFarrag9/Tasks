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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).HasColumnType("nvarchar").IsRequired(true);
            builder.Property(x => x.Salary).HasColumnType("decimal(10,2)").IsRequired(true);
            builder.HasCheckConstraint("check-salary", "Salary > 0");
            builder.Property(x=>x.Address).HasColumnType("nvarchar(150)").IsRequired(false);
            builder.Property(x => x.HourRate).HasColumnType("decimal(10,2)").HasDefaultValue(0);
            builder.HasCheckConstraint("check-hour-rate", "HourRate > 0");


        }
    }
}
