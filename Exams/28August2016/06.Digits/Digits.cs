using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = n / 100;
            int secondNumber = n / 10;
            int secondNumberReal = secondNumber % 10;
            int thirdNumber = n % 10;
            for (int rows = 0; rows < firstNumber + secondNumberReal; rows++)
            {
                for (int cols = 0; cols < firstNumber + thirdNumber; cols++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - firstNumber;
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - secondNumberReal;
                    }
                    else if (n % 5 != 0 && n % 3 != 0)
                    {
                        n = n + thirdNumber;
                    }
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
