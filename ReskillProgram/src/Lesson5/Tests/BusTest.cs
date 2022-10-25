using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson5.Tests
{
    class BusTest
    {
         public static void main(string[] args)
        {

            Chassis chassis = new Chassis(10, 100, 10);
            Engine engine = new Engine("High", 100, "petrol", "HGF11222");
            Transmission transmission = new Transmission("Manual", 100, "VWAGY");

            Console.WriteLine("transmission: " + transmission.NumberOfGears);

            Bus bus = new Bus(chassis, transmission, engine);

            Console.WriteLine("Bus Chassis: " +  bus.Chassis.WheelsNumber);
            Console.WriteLine("Bus Engine: " + bus.Engine.Volume);
            Console.WriteLine("Bus Transmission: " + bus.Transmission.NumberOfGears);
        }
    }
}
