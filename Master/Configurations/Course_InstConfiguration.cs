using Master.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Master.Configurations
{
    internal class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(ci => new { ci.inst_ID, ci.Course_ID });

            builder.HasOne(ci => ci.Instructor)
                   .WithMany(i => i.Course_Instructors)
                   .HasForeignKey(ci => ci.inst_ID);
            builder.HasOne(ci => ci.Course)
                   .WithMany(c => c.Course_Instructors)
                   .HasForeignKey(ci => ci.Course_ID);
            builder.Property(ci => ci.Evaluate)
                   .HasColumnType("int")
                   .IsRequired();

        }
    }
}
