using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.Lesson3
{
    class ConvertNumberToNewBase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type an integer in decimal, and then press Enter:");
            int decimalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a new base number system (from 2 to 20), and then press Enter:");
            int symbobaseNumberls = int.Parse(Console.ReadLine());

            Console.WriteLine("The original number: " + ConvertToBase(decimalNumber, symbobaseNumberls));
        }

        static string ConvertToBase(int decimalNumber, int baseNumber)
        {
            List<Char> result = new List<Char>();

            int j = 0;
            int i = 0;
            int sign = 0;

            if (decimalNumber == 0) result.Add('0');

            if (decimalNumber < 0) 
            { 
                sign = -1;
                decimalNumber = -decimalNumber; 
            }

            while (decimalNumber > 0)
            {
                j = (int)decimalNumber % baseNumber;
                if (j < 10)
                    result.Add((char)(j + '0'));
         
                else
                    result.Add((char)(j + 'A'));

                decimalNumber = (int)(decimalNumber / baseNumber);
                i++;
            }

            if (sign == -1) result.Add('-');

            string final = "";
            for (int h = 0; h < result.Count; h++)
            {
                final =  final + result[h];
            }

            return final;
        }
    }
}
