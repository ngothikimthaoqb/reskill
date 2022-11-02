using ReskillProgram.src.Lesson4.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReskillProgram.src.Lesson4.Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
        {
        }

        public override string ToString()
        {
            return "Bus Chassis: " +  Chassis + "\n" + "Bus Engine: " + Engine + "\n" + "Bus Transmission: " + Transmission + "\n";
        }
    }
}
