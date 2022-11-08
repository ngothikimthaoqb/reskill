using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.CommandPattern.ConcreteCommand
{
    public class CommandTotalNumberOfCars : Command
    {
        private List<Car> cars;

        public CommandTotalNumberOfCars(List<Car> cars)
        {
            this.cars = cars;
        }

        public void Execute(List<Car> cars)
        {
            CarCollection.GetInstance().TotalNumberOfCars(cars);

        }
    }
}
