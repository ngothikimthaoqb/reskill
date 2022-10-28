using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson5.Tests
{
    class DroneTest
    {
        static void Main(string[] args)
        {
            Drone drone = new Drone();
            drone.CurrentPosition = 5;
            drone.FlyTo(1000);
            Console.WriteLine("The time bird take: " + drone.GetFlyTime() + "minutes");
        }
    }
}
