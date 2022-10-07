using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoreDesign.DAL.Entity
{
    public class Road
    {
        public Road()
        {
            this.RoadVehicles = new List<RoadVehicle>();
        }
        public int RoadId { get; set; }

        public int RoadTypeId { get; set; }

        public string? RoadName { get; set; }

        public string? Description { get; set; }

        public RoadType RoadType { get; set; }

        public List<RoadVehicle> RoadVehicles { get; set; }
    }
}
