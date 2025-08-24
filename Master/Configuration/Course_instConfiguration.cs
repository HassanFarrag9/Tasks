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
    internal class Course_instConfiguration : IEntityTypeConfiguration<Course_inst>
    {
        public void Configure(EntityTypeBuilder<Course_inst> builder)
        {
          
            builder.Property(x => x.Evaluate).HasColumnType("int").IsRequired(false);
            builder.HasCheckConstraint("check-Evaluate", "Evaluate between 1 and 10");
        }
    }
}
