using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson9.CustomException
{
    public class GetAutoByParameterException: Exception
    {
        public GetAutoByParameterException()
        : base(String.Format("It is impossible to find the model by the specified parameter"))
        {

        }
    }
}
