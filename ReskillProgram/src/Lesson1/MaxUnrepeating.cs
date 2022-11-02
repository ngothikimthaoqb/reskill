using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.Lesson1
{
    class ConvertDecimalToBase
    {
        static void main(string[] args)
        {
            // Ask the user to type a sequence of symbols
            Console.WriteLine("Type a sequence of symbols, and then press Enter:");
            string symbols = Console.ReadLine();

            Console.WriteLine("The maximum number of unequal consecutive characters:" +
               MaxUnequalConsecutiveCharacters(symbols));
        }
        static int MaxUnequalConsecutiveCharacters(string str)
        {
            int max = 1;
            int count = 1;

            for (int i = 1; i < str.Length - 1; i++)
            {
                bool isRepeated = false;
                for (int j = 0; j < i; j++)
                {
                    if (str[j] == str[i])
                    {
                        isRepeated = true;
                        break;
                    }
                }

                if (isRepeated.Equals(false))
                {
                    count++;
                }
                else
                {
                    if (count > max)
                    {
                        max = count;
                    }
                    count = 1;
                }

            }

            return max;
        }
    }
}
