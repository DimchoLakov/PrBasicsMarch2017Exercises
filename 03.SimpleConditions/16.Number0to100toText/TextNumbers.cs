using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Number0to100toText
{
    class TextNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] digits = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tenToNineteen = new string[10] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", };
            string[] tens = new string[8] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (number >= 0 && number <= 9)
            {
                Console.WriteLine(digits[number]);
            }
            else if (number >= 10 && number <=19)
            {
                Console.WriteLine(tenToNineteen[number - 10]);
            }
            else if (number > 19 && number <= 99) 
            {
                if (number % 10 == 0) 
                {
                    Console.WriteLine(tens[(number/10) -2]); 
                }
                else
                {
                    Console.WriteLine($"{tens[(number/10) -2]} {digits[number % 10]}"); //
                }                                        
            }
            else
                Console.WriteLine("one hundred");
        }
    }
}
