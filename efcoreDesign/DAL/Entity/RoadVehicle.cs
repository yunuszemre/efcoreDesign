using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoreDesign.DAL.Entity
{
    public class RoadVehicle
    {
        public int RoadId { get; set; }
        public int VehicleId { get; set; }

        public virtual Road Road { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}   
