using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.CommandPattern.ConcreteCommand
{
    public class CommandCountTypes : Command
    {
        private List<Car> cars;

        public CommandCountTypes(List<Car> cars)
        {
            this.cars = cars;
        }

        public void Execute(List<Car> cars)
        {
            CarCollection.GetInstance().CountTypes(cars);

        }
    }
}
