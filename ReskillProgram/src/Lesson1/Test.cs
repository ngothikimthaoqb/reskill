﻿using ReskillProgram.Lesson1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson1
{
    public class Test
    {
        static void main(string[] args)
        {
            // Ask the user to type a sequence of symbols
            Console.WriteLine("Type a sequence of symbols, and then press Enter:");
            string symbols = Console.ReadLine();

            MaxUnrepeating maxUnrepeating = new MaxUnrepeating();

            Console.WriteLine("The maximum number of unequal consecutive characters:" +
               maxUnrepeating.MaxUnequalConsecutiveCharacters(symbols));

        }
    }
}
