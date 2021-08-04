using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge_2
{
   public class Vehicle
    {
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string VIN { get; set; }
        public decimal Miles { get; set; }
        public List<Technician> Technicians { get; set; }
    }
}
