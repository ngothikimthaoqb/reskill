

namespace Lesson5.Flys
{
    public class Bird : IFlyable
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
            Random random = new Random();
            int distance = ToPosition.GetDistance() - CurrentPosition.GetDistance();

            //Speed in the range of 0-20 km/h (set randomly)
            int speed = random.Next(20);
            int time = distance / speed * 60;

            this.Time = time;

        }

        public override string ToString()
        {
            return "Time Airplane: " + this.Time + "hour";
        }
       
    }
}
