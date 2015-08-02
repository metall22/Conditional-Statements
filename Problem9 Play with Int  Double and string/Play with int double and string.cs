using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9_Play_with_Int__Double_and_string
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 1-->int/n2-->double/n3->-string:");
            int userChoice=int.Parse(Console.ReadLine());
            switch (userChoice)
	{
                case 1:Console.WriteLine("Please enter int");
                    int a =int.Parse(Console.ReadLine());
                    Console.WriteLine(a+1);break;

                case 2:Console.WriteLine("Please enter a double");
                    double b=double.Parse(Console.ReadLine());
                    Console.WriteLine(b+1);break;

                case 3:Console.WriteLine("Please enter string");
                    string input=Console.ReadLine();
                    Console.WriteLine(input+"*");break;
                default: Console.WriteLine("Error");
        break;
	 }
            }

        }
    }

