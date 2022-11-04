using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Flys
{
    public class Drone : IFlyable
    {
        public Coordinate CurrentPosition { get; set; }
        public Coordinate ToPosition { get; set; }

        public int Time { get; set; }

        public void FlyTo(Coordinate ToPosition)
        {
            this.ToPosition = ToPosition;
        }


        public void GetFlyTime(Coordinate ToPosition)
        {
            int distance = ToPosition.GetDistance() - CurrentPosition.GetDistance();
            Random random = new Random();
           
            //The speed is random  the range of 0-100 km/h 
            int speed = random.Next(100);

            //The drone hovers in the air every 10 minutes of flight for 1 minute
            int time = (distance / speed) * 60 - (distance / 10);

            this.Time = time;
        }

        public override string ToString()
        {
            return "Time Airplane: " + this.Time + "hour";
        }
        
    }
}
