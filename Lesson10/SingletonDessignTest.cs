using Lesson10;

public class SingletonDessignTest
{

    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();

        Console.WriteLine("Number of car:");
        int numberOfCar = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCar; i++)
        {
            Console.WriteLine("Type brand:");
            string branch = Console.ReadLine();
            Console.WriteLine("Type model:");
            string model = Console.ReadLine();
            Console.WriteLine("Type quantity:");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Type cost :");
            int cost = int.Parse(Console.ReadLine());

            Car car = new Car(branch, model, quantity, cost);
            cars.Add(car);
        }

        CarCollection carCollection = CarCollection.GetInstance();
        carCollection.AverageCost(cars);
        carCollection.AveragePriceType(cars);
        carCollection.CountTypes(cars);
        carCollection.TotalNumberOfCars(cars);

    }

}