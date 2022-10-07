using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoreDesign.DAL.Entity
{
    public class VehicleType
    {
        public VehicleType()
        {
            this.Vehicles = new List<Vehicle>();
        }        

        public string? VehicleTypeName { get; set; }

        public int VehicleTypeId { get; set; }

        public List<Vehicle> Vehicles { get; set; }
    }
}
