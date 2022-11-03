using ReskillProgram.src.Lesson4.CarParts;
using ReskillProgram.src.Lesson4.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson4.Tests
{
    class ScooterTest
    {
         
        public static void main(string[] args)
        {
            Chassis chassis = new Chassis(10, 100, 10);
            Engine engine = new Engine("High", 100, "petrol", "HGF11222");
            Transmission transmission = new Transmission("Manual", 100, "VWAGY");
            Scooter scooter = new Scooter(chassis, transmission, engine);
            Console.WriteLine("Scooter info:" + scooter.ToString());
        }
         
    }
}
