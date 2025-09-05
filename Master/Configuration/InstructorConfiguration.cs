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
            builder.HasIndex(x=>x.Email).IsUnique();
            builder.HasMany(x=>x.courseSchedules)
                .WithOne(x=>x.Instructor)
                .HasForeignKey(x=>x.InsId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
