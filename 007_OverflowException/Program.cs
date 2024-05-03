﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_OverflowException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue;
            int y = 0;

            checked
            {
                try
                {
                    y = x + 10;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.Maxvalue + 10 = {0}", y);
        }
    }
}
