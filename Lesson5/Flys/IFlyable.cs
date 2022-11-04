using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Flys
{
    interface IFlyable
    {
        public Coordinate CurrentPosition { get; set; }
        public Coordinate ToPosition { get; set; }
        public int Time { get; set; }

        public void FlyTo(Coordinate ToPosition);
        public void GetFlyTime(Coordinate ToPosition);
    }
}
