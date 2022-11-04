

namespace Lesson5.Flys
{
    public class Airplane : IFlyable
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
            int initialSpeed = 200;
            int distance = ToPosition.GetDistance() - CurrentPosition.GetDistance();

            //the aircraft increases speed by 10 km/h every 10 km of flight from an initial speed of 200 km/h
            int speed;

            if (distance < 10)
            {
                speed = initialSpeed;
            }
            else
            {
                speed = distance * initialSpeed;
            }

            int time = distance / speed * 60;

            this.Time = time;
        }

        public override string ToString()
        {
            return "Time Airplane: " + this.Time + "hour" ;
        }
    }
}
