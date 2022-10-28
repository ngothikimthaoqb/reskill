using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson5.Tests
{
    class AirplanTest
    {
         public static void main(string[] args)
        {
            Airplane airplane = new Airplane();
            airplane.CurrentPosition = 5;
            airplane.FlyTo(1000);
            Console.WriteLine("The time airplane take: " + airplane.GetFlyTime());
        }
    }
}
