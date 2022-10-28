using ReskillProgram.src.Lesson5.Coordinate;
using System;

public class Drone : IFlyable
{

    public int CurrentPosition { get; set; }
    public int ToPosition { get; set; }

    public void FlyTo(int newPoint)
    {
       this.ToPosition = newPoint;
    }

    public int GetFlyTime()
    {
        Random random = new Random();
        int distance = ToPosition - CurrentPosition;

        //The speed is random  the range of 0-100 km/h 
        int speed = random.Next(100);

        //The drone hovers in the air every 10 minutes of flight for 1 minute
        int time = (distance / speed) * 60 - (distance / 10) ;

        return time;
    }
}
