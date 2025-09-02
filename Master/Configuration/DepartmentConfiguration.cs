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
            builder.HasOne(x => x.Manager)
            .WithOne(x => x.ManagerDepartment)
            .HasForeignKey<Department>(x => x.ManagerID)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
