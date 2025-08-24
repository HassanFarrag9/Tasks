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
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).HasColumnType("nvarchar").IsRequired(true);
            builder.Property(x=>x.HiringDate).HasColumnType("Date").IsRequired(true);
            builder.HasCheckConstraint("CK_Employee_HiringDate", "HiringDate <= GETDATE()");
        }
    }
}
