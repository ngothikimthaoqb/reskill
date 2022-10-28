using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson5.Tests
{
    class BirdTest
    {
         public static void main(string[] args)
        {
            Bird bird = new Bird();
            bird.CurrentPosition = 5;
            bird.FlyTo(1000);
            Console.WriteLine("The time bird take: " + bird.GetFlyTime() + "minutes");
        }
    }
}
