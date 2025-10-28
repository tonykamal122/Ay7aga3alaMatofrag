using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalLibraryMangementSystemDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalLibraryMangementSystemDAL.Data.Configurations
{
    public class FineConfigurations : IEntityTypeConfiguration<Fine>
    {
        public void Configure(EntityTypeBuilder<Fine> builder)
        {
            builder.HasOne(F => F.Loan)
                   .WithOne(F => F.Fine)
                   .HasForeignKey<Fine>(F => F.LoanId);

            builder.Ignore(F => F.Title);
        }
    }
}