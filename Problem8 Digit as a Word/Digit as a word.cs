using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8_Digit_as_a_Word
{
    class DigitasWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between (0-9)");
            string n = Console.ReadLine();
            
          

            
            switch (n)
            {
                case "0": Console.WriteLine("Zero"); break;
                case "1": Console.WriteLine("One"); break;
                case "2": Console.WriteLine("Two"); break;
                case "3": Console.WriteLine("Tree"); break;
                case "4": Console.WriteLine("Four"); break;
                case "5": Console.WriteLine("Five"); break;
                case "6": Console.WriteLine("Six"); break;
                case "7": Console.WriteLine("Seven"); break;
                case "8": Console.WriteLine("Eight"); break;
                case "9": Console.WriteLine("Nine"); break;

                default:
                    
                        Console.WriteLine("Not a digit");
                    
                    break;
              
            }
        }
    }
    }
