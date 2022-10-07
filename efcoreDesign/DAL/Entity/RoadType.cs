using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoreDesign.DAL.Entity
{
    public class RoadType
    {
        public RoadType()
        {
            this.Roads = new List<Road>();
        }
        public int RoadTypeId { get; set; }

        public string? RoadTypeName { get; set; }

        public List<Road> Roads { get; set; }

    }
}
