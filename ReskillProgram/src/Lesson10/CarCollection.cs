using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson10
{
    public class CarCollection
    {
        public int CountTypes(List<Car> cars)
        {
            int numberOfType = 1;
            for (int i = 0; i < cars.Count; i++)
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

            return numberOfType;
        }

        public int TotalNumberOfCars(List<Car> cars)
        {
            int numberOfCar = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                numberOfCar += cars[i].Quantity;

            }

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
