using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public sealed class CarCollection
    {
        private static int counter = 0;
        private static CarCollection instance = null;
        public static CarCollection GetInstance()
        {
           if (instance == null) instance = new CarCollection();
                
           return instance;
        }

        private CarCollection()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public int CountTypes(List<Car> cars)
        {
            int numberOfType = 1;
            for (int i = 0; i < cars.Count - 1; i++)
            {
                bool repeat = false;
                for (int j = i; j < cars.Count; j++)
                {
                    if (cars[i].Brand == cars[i + 1].Brand)
                    {
                        repeat = true;
                    }
                }

                if (!repeat)
                {
                    numberOfType += 1;
                }

            }
            Console.WriteLine("The number of types:" + numberOfType);

            return numberOfType;
        }

        public int TotalNumberOfCars(List<Car> cars)
        {
            int numberOfCar = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                numberOfCar += cars[i].Quantity;

            }

            Console.WriteLine("The number of cars:" + numberOfCar);

            return numberOfCar;
        }

        public decimal AverageCost(List<Car> cars)
        {
            int totalCars = 0;
            int totalCost = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                totalCars += cars[i].Quantity;
                totalCost += cars[i].Cost * cars[i].Quantity;

            }

            Console.WriteLine("The average cost:" + totalCost);

            return totalCost / totalCars;
        }

        public void AveragePriceType(List<Car> cars)
        {

            var typeGroups = from car in cars group car by car.Brand;

            foreach (var typeGroup in typeGroups)
            {
                int totalCars = 0;
                int totalCost = 0;
                foreach (var car in typeGroup)
                {
                    totalCars += car.Quantity;
                    totalCost += car.Cost * car.Quantity;
                }

                decimal averagePriceType = totalCost / totalCars;

                Console.WriteLine("Average Price of Type " + typeGroup.Key + ":" + averagePriceType);
            }

        }
    }
}
