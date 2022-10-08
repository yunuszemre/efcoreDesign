using efcoreDesign.DAL.Configuration;
using efcoreDesign.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoreDesign.DAL.Context
{
    public class DesignContext:DbContext
    {
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Road> Roads { get; set; }
        public DbSet<RoadType> RoadTypes { get; set; }
        public DbSet<RoadVehicle> RoadVehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IPVME9J\YUNUS; Database=DesignDB; uid=sa; pwd=1234");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<VehicleType>(new VehicleTypeConfiguration());
            modelBuilder.ApplyConfiguration<Vehicle>(new VehicleConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleModelConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new RoadConfiguration());
            modelBuilder.ApplyConfiguration(new RoadVehicleConfiguration());
            modelBuilder.ApplyConfiguration(new RoadTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
