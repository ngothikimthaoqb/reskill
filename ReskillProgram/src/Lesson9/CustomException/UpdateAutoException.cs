using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson9.CustomException
{
    public class UpdateAutoException: Exception
    {
        public UpdateAutoException(string item)
        : base(String.Format("It is impossible to replace", item))
        {

        }
    }
}
