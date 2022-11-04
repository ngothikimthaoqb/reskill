using Lesson5.Flys;


namespace Lesson5.Tests
{
    class Test
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Number 1: Bird\nNumber 2: Drone\nNumber 3: AirPlane\n");

            Console.WriteLine("Enter the number to choose type of test:");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Console.WriteLine("The Bird test:");
                    BirdTest();
                    break;
                case 2:
                    Console.WriteLine("The Drone test");
                    DroneTest();
                    break;
                case 3:
                    Console.WriteLine("The Airplan test");
                    AirplanTest();
                    break;
                default:
                    Console.WriteLine("You need to enter the number!");
                    break;
            }
        }
         
        public static void AirplanTest()
        {
            Airplane airplane = new Airplane();
            airplane.CurrentPosition = new Coordinate(200, 100, 200);
            airplane.FlyTo(new Coordinate(4000, 3000, 5000));
            airplane.GetFlyTime(new Coordinate(4000, 3000, 5000));
            Console.WriteLine(airplane.ToString());
        }

        public static void DroneTest()
        {
            Drone drone = new Drone();
            drone.CurrentPosition = new Coordinate(0, 100, 400); ;
            drone.FlyTo(new Coordinate(2000, 1000, 2000));
            drone.GetFlyTime(new Coordinate(2000, 1000, 2000));

            Console.WriteLine(drone.ToString());

        }

        public static void BirdTest()
        {
            Bird bird = new Bird();
            bird.CurrentPosition = new Coordinate(200, 100, 200);
            bird.FlyTo(new Coordinate(2000, 1000, 2000));
            bird.GetFlyTime(new Coordinate(2000, 1000, 2000));

            Console.WriteLine(bird.ToString());
        }
    }
}
