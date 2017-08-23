using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Same3Numbers
{
    class SameNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber && secondNumber == thirdNumber)
            {
                Console.WriteLine("yes");
            }
            else if (firstNumber == secondNumber && secondNumber != thirdNumber)
            {
                Console.WriteLine("no");
            }
            else if (thirdNumber == firstNumber && secondNumber != thirdNumber)
            {
                Console.WriteLine("no");
            }
            else if (thirdNumber == firstNumber && secondNumber != firstNumber)
            {
                Console.WriteLine("no");
            }
            else if (firstNumber != secondNumber && secondNumber != thirdNumber)
            {
                Console.WriteLine("no");
            }
            else if (firstNumber != secondNumber && secondNumber == thirdNumber)
            {
                Console.WriteLine("no");
            }

        }
    }
}
