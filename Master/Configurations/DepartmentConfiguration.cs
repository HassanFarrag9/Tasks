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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.ID);
            builder.HasOne(d => d.Instructor)
                   .WithOne()
                   .HasForeignKey<Department>(d => d.Ins_ID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
