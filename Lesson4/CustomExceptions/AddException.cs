

namespace Lesson4.CustomExceptions
{
    public class AddException : Exception
    {
        public AddException()
        : base(String.Format("It is impossible to add"))
        {

        }
    }

}
