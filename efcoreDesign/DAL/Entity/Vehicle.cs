using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoreDesign.DAL.Entity
{
    public class Vehicle
    {
        public Vehicle()
        {
            this.RoadVehicles = new List<RoadVehicle>();
        }

        public int VehicleId { get; set; }

        public int VehicleTypeId { get; set; }

        public int BrandId { get; set; }
        
        public virtual VehicleModel VehicleModel { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual VehicleType VehicleType { get; set; }

        public List<RoadVehicle> RoadVehicles { get; set; }
    }
}
