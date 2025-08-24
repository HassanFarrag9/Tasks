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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Fname).HasMaxLength(50).HasColumnType("nvarchar").IsRequired(true);
            builder.Property(x => x.Lname).HasMaxLength(50).HasColumnType("nvarchar").IsRequired(true);
            builder.Property(x => x.Address).HasMaxLength(150).HasColumnType("nvarchar").IsRequired(false);
            builder.Property(x => x.Age).HasColumnType("int").IsRequired(true);



        }
    }
}
