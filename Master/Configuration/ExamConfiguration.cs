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
    internal class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasCheckConstraint("CK_Exam_Type","Type in ('Midterm','Final')");
            builder.HasMany(x=>x.examResults)
                .WithOne(x=>x.Exam)
                .HasForeignKey(x=>x.ExamId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
