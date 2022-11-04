
namespace Lesson4.CustomExceptions
{
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException(string message)
        : base(String.Format(message))
        {

        }
    }
}
