using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson9.CustomException
{
    public class AddException: Exception
    {
        public AddException(string item)
        : base(String.Format("It is impossible to add", item))
        {

        }
    }
    
}
