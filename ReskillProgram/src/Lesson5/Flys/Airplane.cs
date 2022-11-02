﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson5.Flys
{
    public class Airplane : IFlyable
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
            int initialSpeed = 200;
            int distance = ToPosition - CurrentPosition;

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

            return time;
        }

        public override string ToString()
        {
            return "Time Airplane: " + GetFlyTime();
        }
    }
}