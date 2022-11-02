using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson4.CarParts
{
    public class Engine
    {
        private string Power { get; set; }
        private int Volume { get; set; }
        private string Type { get; set; }
        private string SerialNumber { get; set; }

        public Engine(string power, int volume, string type, string serialNumber)
        {
            this.Power = power;
            this.Volume = volume;
            this.Type = type;
            this.SerialNumber = serialNumber;
        }

        public override string ToString()
        {
            return "Engine: " + "\n" + "Power:" + Power + "\n" + "Volume:" + Volume + "\n" + "Type:" + Type + "\n" + "SerialNumber:" + SerialNumber;
        }
    }
}
