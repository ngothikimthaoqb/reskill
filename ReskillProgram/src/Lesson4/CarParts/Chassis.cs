
using ReskillProgram.src.Lesson4.Vehicles;

namespace ReskillProgram.src.Lesson4.CarParts
{
    public class Chassis
    {
        private int WheelsNumber { get; set; }
        private int Number { get; set; }
        private int PermissibleLoad { get; set; }

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
