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
    internal class ClassroomConfigurationL : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasCheckConstraint("CK_Classroom_Capacity","Capacity > 0");
            builder.HasMany(x => x.courseSchedules)
                .WithOne(x => x.Classroom)
                .HasForeignKey(x => x.ClassRoomId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
