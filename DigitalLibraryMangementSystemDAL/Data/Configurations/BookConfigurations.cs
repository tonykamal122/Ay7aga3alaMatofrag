using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalLibraryMangementSystemDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalLibraryMangementSystemDAL.Data.Configurations
{
    public class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasOne(B => B.BookAuthor)
                   .WithMany(A => A.AuthorBooks)
                   .HasForeignKey(B => B.AuthorId)
                   .OnDelete(DeleteBehavior.Restrict); // NO ACTION on delete

            builder.HasOne(B => B.BookCategory)
                   .WithMany(A => A.CategoryBooks)
                   .HasForeignKey(B => B.CategoryId);



        }
    }
}