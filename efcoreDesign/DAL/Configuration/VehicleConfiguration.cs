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
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(t0=>t0.VehicleId);

            builder.HasOne(t0 => t0.Brand).WithMany(t1 => t1.Vehicles).HasForeignKey(t2 => t2.BrandId);
            builder.HasOne(t0 => t0.VehicleType).WithMany(t1 => t1.Vehicles).HasForeignKey(t2 => t2.VehicleTypeId);
            builder.HasOne(t0 => t0.VehicleModel).WithOne(t1 => t1.Vehicle).HasForeignKey<VehicleModel>(t2 => t2.VehicleId);
            
        }
    }
}
