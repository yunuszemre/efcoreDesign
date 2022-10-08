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
    public class VehicleModelConfiguration : IEntityTypeConfiguration<VehicleModel>
    {
        public void Configure(EntityTypeBuilder<VehicleModel> builder)
        {
            builder.HasKey(t0 => t0.VehicleModelId);
            builder.Property(t0 => t0.VehicleModelName).HasMaxLength(50);

            builder.HasOne(t0 => t0.Brand).WithMany(t1 => t1.Models).HasForeignKey(t2 => t2.BrandId);
        }
    }
}
