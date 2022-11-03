using ReskillProgram.src.Lesson4.CarParts;
using ReskillProgram.src.Lesson4.Vehicles;


namespace ReskillProgram.src.Lesson4.Tests
{
    class BusTest
    {
        
        public static void main(string[] args)
        {
            Chassis chassis = new Chassis(10, 100, 10);
            Engine engine = new Engine("High", 100, "petrol", "HGF11222");
            Transmission transmission = new Transmission("Manual", 100, "VWAGY");
            Bus bus = new Bus(chassis, transmission, engine);
            Console.WriteLine("Bus info:" + bus.ToString());
        }
        
    }
}
