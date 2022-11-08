using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.CommandPattern
{
    public class CarCollectionInvoker
    {
        private Command? Command;

        public void SetCommand(Command command)
        {
            this.Command = command;
        }

        public void Run(List<Car> cars)
        {
            this.Command?.Execute(cars);
        }
           
    }
}
