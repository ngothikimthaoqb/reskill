﻿using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.Lesson3
{
    public class DecimalToBase
    {
         /*
        static void Main(string[] args)
        {
            Console.WriteLine("Type a sequence of decimal number, and then press Enter:");
            int decimalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a sequence of number base, and then press Enter:");
            int numberBase = int.Parse(Console.ReadLine());
            Console.WriteLine("The original number converted to this system:" +
               ConvertDecimalToBase(decimalNumber, numberBase));
        }
       */

        public static string ConvertDecimalToBase(int decimalNumber, int numberBase)
        {
            const int base10 = 10;
            char[] cHexa = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
            string strBin = "";
            int[] result = new int[32];
            int MaxBit = 32;

            for (; decimalNumber > 0; decimalNumber /= numberBase)
            {
                int rem = decimalNumber % numberBase;
                result[--MaxBit] = rem;
            }

            for (int i = 0; i < result.Length; i++)
                if ( (int) result.GetValue(i) >= base10)
                    strBin += cHexa[ (int) result.GetValue(i) % base10];
                else
                    strBin += result.GetValue(i);

            strBin = strBin.TrimStart(new char[] { '0' });

            return strBin;
        }
    }
}