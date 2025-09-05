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
            builder.HasIndex(x=>x.Name).IsUnique();
            builder.HasOne(x => x.Manager)
                .WithOne(x => x.ManageDepartment)
                .HasForeignKey<Department>(x => x.ManagerId);
        }
    }
}
