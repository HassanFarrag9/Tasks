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
    internal class Stud_CourseConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.HasKey(sc => new { sc.stud_ID, sc.Course_ID });
            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.Stud_Courses)
                   .HasForeignKey(sc => sc.stud_ID);
            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.Stud_Courses)
                   .HasForeignKey(sc => sc.Course_ID);

        }
    }
}
