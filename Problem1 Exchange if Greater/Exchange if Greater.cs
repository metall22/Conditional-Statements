﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_Exchange_if_Greater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} {1}", b, a);
            }
            else 
            {
                Console.WriteLine("{0} {1}",a,b);
            }

        }
    }
}
