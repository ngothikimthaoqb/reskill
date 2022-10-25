using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson5.Tests
{
    class TruckTest
    {
        static void Main(string[] args)
        {

            Chassis chassis = new Chassis(10, 100, 10);
            Engine engine = new Engine("High", 100, "petrol", "HGF11222");
            Transmission transmission = new Transmission("Manual", 100, "VWAGY");

            Truck truck = new Truck(chassis, transmission, engine);

            Console.WriteLine("Truck Chassis: " + truck.Chassis.WheelsNumber);
            Console.WriteLine("Truck Engine: " +  truck.Engine.Volume);
            Console.WriteLine("Truck Transmission: " + truck.Transmission.NumberOfGears);
        }
    }
}
