using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson9.CustomException
{
    public class RemoveAutoException: Exception
    {
        public RemoveAutoException(string item)
        : base(String.Format("It is impossible to remove ", item))
        {

        }
    }
}
