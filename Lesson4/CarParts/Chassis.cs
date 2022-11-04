

namespace Lesson4.CarParts
{
    public class Chassis
    {
        public int WheelsNumber { get; set; }
        public int Number { get; set; }
        public int PermissibleLoad { get; set; }

        public Chassis() { }
        public Chassis(int wheelsNumber, int number, int permissibleLoad)
        {
            Number = number;
            WheelsNumber = wheelsNumber;
            PermissibleLoad = permissibleLoad;
        }

        public override string ToString()
        { 
            return "Chassis: " + "\n" + "WheelsNumber:" + WheelsNumber + "\n" + "Number:" + Number + "\n" + "PermissibleLoad:" + PermissibleLoad;
        }
    }
}
