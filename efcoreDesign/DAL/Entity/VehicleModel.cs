using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoreDesign.DAL.Entity
{
    public class VehicleModel
    {
        public int VehicleModelId { get; set; }

        public string? VehicleModelName { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
