using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.Lesson1
{
    public class MaxUnrepeating
    {
        public int MaxUnequalConsecutiveCharacters(string str)
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

        public int MaximumNumberConsecutiveIdenticalDigits(string str)
        {

            int max = 1;
           
            for (int i = 1; i < str.Length - 1; i++)
            {
                    for (int j = 0; j < str.Length; i++)
                    {
                        if (Char.IsNumber(str[j]) && str[j] == str[i])
                        {
                            if(max < j - i)
                            {
                                max = j - i;
                                i = j;
                            }
                        }
                    }
                
            }

            return max;
        }
    

        public int MaximumNumberConsecutiveIdenticalLeters(string str)
        {
            int max = 1;
            int count = 1;

            for (int i = 1; i < str.Length - 1; i++)
            {
                bool isRepeated = false;
                for (int j = 0; j < i; j++)
                {
                    if (str[j] == str[i] && Char.IsLetter(str[j]))
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
