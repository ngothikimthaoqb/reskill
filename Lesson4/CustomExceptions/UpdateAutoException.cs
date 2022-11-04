

namespace Lesson4.CustomExceptions
{
    public class UpdateAutoException : Exception
    {
        public UpdateAutoException(string item)
        : base(String.Format("It is impossible to replace", item))
        {

        }
    }
}
