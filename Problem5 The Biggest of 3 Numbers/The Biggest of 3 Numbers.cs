using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_The_Biggest_of_3_Numbers
{
    class BiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Biggest:"+a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Biggest:"+ b);
            }
             if(c>a&&c>b)
            {
                Console.WriteLine("Biggest:"+c);
            }
        }
    }
}
