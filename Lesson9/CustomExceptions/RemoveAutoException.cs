using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson9.CustomExceptions
{
    public class RemoveAutoException : Exception
    {
        public RemoveAutoException()
        : base(String.Format("It is impossible to remove"))
        {

        }
    }
}
