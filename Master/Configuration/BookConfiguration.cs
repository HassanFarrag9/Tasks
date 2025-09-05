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
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasIndex(x => x.ISBN).IsUnique();
            builder.HasOne(x=>x.Library)
                .WithMany(x=>x.books)
                .HasForeignKey(x=>x.LibraryId)
                .OnDelete(DeleteBehavior.NoAction); 
            builder.HasMany(x=>x.Bookloans)
                .WithOne(x=>x.Book)
                .HasForeignKey(x=>x.BookId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
