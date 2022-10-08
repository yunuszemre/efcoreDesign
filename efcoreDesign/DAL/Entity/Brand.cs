using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoreDesign.DAL.Entity
{
    public class Brand
    {
        public Brand()
        {
            this.Vehicles = new List<Vehicle>();
            this.Models = new List<VehicleModel>();
        }
        public int BrandId { get; set; }
        public string? BrandName { get; set; }
        public List<VehicleModel> Models { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
