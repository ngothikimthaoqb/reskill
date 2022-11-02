using ReskillProgram.src.Lesson4.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson4.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
        {
        }

        public override string ToString()
        {
            return "Truck Chassis: " + Chassis + "\n" + "Truck Engine: " + Engine + "\n" + "Truck Transmission: " + Transmission + "\n";
        }
    }
}
