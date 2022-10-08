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
    public class RoadVehicleConfiguration : IEntityTypeConfiguration<RoadVehicle>
    {
        public void Configure(EntityTypeBuilder<RoadVehicle> builder)
        {
            builder.HasKey(t0=> new {t0.RoadId,t0.VehicleId});

            builder.HasOne(t0 => t0.Vehicle).WithMany(t1 => t1.RoadVehicles).HasForeignKey(t2 => t2.VehicleId);
            builder.HasOne(t0=>t0.Road).WithMany(t1=>t1.RoadVehicles).HasForeignKey(t2=>t2.RoadId);
        }
    }
}
