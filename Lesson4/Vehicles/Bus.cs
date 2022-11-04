using Lesson4.CarParts;


namespace Lesson4.Vehicles
{
    public class Bus : Vehicle
    {
        public Bus() { }
        public Bus(Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
        {
        }

        public override string ToString()
        {
            return "Bus Chassis: " +  Chassis + "\n" + "Bus Engine: " + Engine + "\n" + "Bus Transmission: " + Transmission + "\n";
        }
    }
}
