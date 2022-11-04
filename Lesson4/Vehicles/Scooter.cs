using Lesson4.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Vehicles
{
    public class Scooter : Vehicle
    {
        public Scooter() { }
        public Scooter(Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
        {
        }

        public override string ToString()
        {
            return "Scooter Chassis: " + Chassis + "\n" + "Scooter Engine: " + Engine + "\n" + "Scooter Transmission: " + Transmission + "\n";
        }
    }
}
