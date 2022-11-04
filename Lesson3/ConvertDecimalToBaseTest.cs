using Lesson3;

namespace ReskillProgram.Lesson3
{
    public class ConvertDecimalToBaseTest
    {
        
        static void Main(string[] args)
        {

            ConvertDecimalToBase decimalToBase = new ConvertDecimalToBase();
            Console.WriteLine("Type a sequence of decimal number, and then press Enter:");
            int decimalNumber = int.Parse(Console.ReadLine());
            int numberBase;
            bool isIncorrectNumber;
            do
            {
                Console.WriteLine("Type a sequence of number base, and then press Enter:");
                numberBase = int.Parse(Console.ReadLine());
               
                isIncorrectNumber = numberBase > 2 && numberBase < 20;
            } while (!isIncorrectNumber);
          
            Console.WriteLine("The original number converted to this system:" +
               decimalToBase.ConvertDecimalToAnyBase(decimalNumber, numberBase));
        }
       

    }
}
