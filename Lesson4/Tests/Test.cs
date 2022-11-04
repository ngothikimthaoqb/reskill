using Lesson4.CarParts;
using Lesson4.Vehicles;

namespace Lesson5.Tests
{
    class Test
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Number 1: Bus\n Number 2: PassangerCar\n Number 3: Scooter\n Number 4: Truck\n");

            Console.WriteLine("Enter the number to choose type of test:");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Console.WriteLine("The Bus test:");
                    BusTest();
                    break;
                case 2:
                    Console.WriteLine("The PassangerCar test");
                    TruckTest();
                    break;
                case 3:
                    Console.WriteLine("The Scooter test");
                    CooterTest();
                    break;
                case 4:
                    Console.WriteLine("The Truck test");
                    PassengerCarTest();
                    break;
                    
                default:
                    Console.WriteLine("You need to enter the number!");
                    break;
            }
        }
         
        public static void BusTest()
        {
            Chassis chassis = new Chassis(10, 100, 10);
            Engine engine = new Engine("High", 100, "petrol", "HGF11222");
            Transmission transmission = new Transmission("Manual", 100, "VWAGY");
            Bus bus = new Bus(chassis, transmission, engine);
            Console.WriteLine("Bus info:" + bus.ToString());
        }

        public static void TruckTest()
        {
            Chassis chassis = new Chassis(10, 100, 10);
            Engine engine = new Engine("High", 100, "petrol", "HGF11222");
            Transmission transmission = new Transmission("Manual", 100, "VWAGY");
            Truck truck = new Truck(chassis, transmission, engine);
            Console.WriteLine("Truck info:" + truck.ToString());

        }

        public static void CooterTest()
        {
            Chassis chassis = new Chassis(10, 100, 10);
            Engine engine = new Engine("High", 100, "petrol", "HGF11222");
            Transmission transmission = new Transmission("Manual", 100, "VWAGY");
            Scooter scooter = new Scooter(chassis, transmission, engine);
            Console.WriteLine("Scooter info:" + scooter.ToString());
        }

        public static void PassengerCarTest()
        {
            Chassis chassis = new Chassis(10, 100, 10);
            Engine engine = new Engine("High", 100, "petrol", "HGF11222");
            Transmission transmission = new Transmission("Manual", 100, "VWAGY");
            PassengerCar passengerCar = new PassengerCar(chassis, transmission, engine);
            Console.WriteLine("PassengerCarTest info:" + passengerCar.ToString());
        }


       
    }
}
