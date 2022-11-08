using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.CommandPattern
{
    public interface Command
    {
        public void Execute(List<Car> cars);
    }
}
