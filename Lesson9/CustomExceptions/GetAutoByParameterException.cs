using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson9.CustomExceptions
{
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException(string message)
        : base(String.Format(message))
        {

        }
    }
}
