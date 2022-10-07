using efcoreDesign.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoreDesign.DAL.Configuration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.BrandId);
            builder.Property(t0 => t0.BrandName).HasMaxLength(100);
            
            builder.HasData(
                
                new Brand() { BrandId=1, BrandName="BMW"},
                new Brand() { BrandId = 2, BrandName = "Mercedes" },
                new Brand() { BrandId = 3, BrandName = "Hyundai" },
                new Brand() { BrandId = 4, BrandName = "Volkswagen" },
                new Brand() { BrandId = 5, BrandName = "Ford" },
                new Brand() { BrandId = 6, BrandName = "Volvo" }
                )
        }
    }
}
