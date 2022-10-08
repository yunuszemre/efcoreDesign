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
    public class RoadTypeConfiguration : IEntityTypeConfiguration<RoadType>
    {
        public void Configure(EntityTypeBuilder<RoadType> builder)
        {
            builder.HasKey(t0=>t0.RoadTypeId);
            builder.Property(t0 => t0.RoadTypeName).HasMaxLength(100);

           
        }
    }
}
