using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReskillProgram.src.Lesson5.Coordinate
{
    internal interface IFlyable
    {
        public int CurrentPosition { get; set; }
        public int ToPosition { get; set; }

        public void FlyTo(int newPoint);
        public int GetFlyTime();
    }
}
