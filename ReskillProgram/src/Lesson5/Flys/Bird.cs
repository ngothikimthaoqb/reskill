using ReskillProgram.src.Lesson5.Coordinate;
using System;

public class Bird : IFlyable
{
    public int CurrentPosition { get ; set ; }

    public int ToPosition { get ; set ; }

    public void FlyTo(int newPoint)
    {
        this.ToPosition = newPoint;
    }

    public int GetFlyTime()
    {
        Random random = new Random();
        int distance = this.ToPosition - this.CurrentPosition;

        //Speed in the range of 0-20 km/h (set randomly)
        int speed = random.Next(20);
        int time = distance / speed * 60;

        return time;
    }
}
