using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.CarParts
{
    public class Engine
    {
        public string Power { get; set; }
        public int Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

        public Engine() { }
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
