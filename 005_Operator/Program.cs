﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3 + 4 * 5);
            Console.WriteLine((3 + 4) * 5);
            Console.WriteLine(3 *3 / 5);
            Console.WriteLine(4 / 5 * 3);

            int a = 10;
            int b = 20;
            int c;
            Console.WriteLine(c = a + b);
        }
    }
}
