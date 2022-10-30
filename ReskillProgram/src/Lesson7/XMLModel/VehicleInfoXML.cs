using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson5.XMLModel
{
    public class VehicleInfoXML
    {
        public Bus? Bus { get; set; }
        public Truck? Truck { get; set; }
        public Scooter? Scooter { get; set; }

        public PassengerCar? PassengerCar { get; set; }
    }
}
