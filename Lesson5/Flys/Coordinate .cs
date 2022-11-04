﻿

namespace Lesson5.Flys
{
    public class Coordinate
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Coordinate(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int GetDistance()
        {
            return (int)Math.Sqrt( X + Y + Z);
        }

    }
}
