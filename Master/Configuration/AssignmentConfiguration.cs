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
    internal class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasMany(x => x.submissions)
                .WithOne(x => x.Assignment)
                .HasForeignKey(x => x.AssignmentId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
