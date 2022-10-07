using efcoreDesign.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoreDesign.DAL.Configuration
{
    public class RoadConfiguration : IEntityTypeConfiguration<Road>
    {
        public void Configure(EntityTypeBuilder<Road> builder)
        {
            builder.HasKey(t0 => t0.RoadId);
            builder.Property(t0 => t0.Description).HasMaxLength(500);
            builder.Property(t0 => t0.RoadName).HasMaxLength(50);

            builder.HasOne(t0 => t0.RoadType).WithMany(t1 => t1.Roads).HasForeignKey(t2 => t2.RoadTypeId);

        }
    }
}
