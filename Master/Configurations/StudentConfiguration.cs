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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.FName).HasMaxLength(50).IsRequired();
            builder.Property(s => s.LName).HasMaxLength(50).IsRequired();
            builder.HasOne(s => s.Department)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.Dep_Id)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
