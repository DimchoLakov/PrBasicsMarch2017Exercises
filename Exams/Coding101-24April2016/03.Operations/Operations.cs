using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Operations
{
    class Operations
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            string oddOrEven = null;
            double sum = 0.0d;
            bool plus = symbol == '+';
            bool minus = symbol == '-';
            bool multiply = symbol == '*';
            bool divide = symbol == '/';
            bool divideResidue = symbol == '%';

            if (plus || minus || multiply)
            {
                if (plus)
                {
                    sum = n1 + n2;
                }
                else if (minus)
                {
                    sum = n1 - n2;
                }
                else if (multiply)
                {
                    sum = n1 * n2;
                }
                if (sum % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
                Console.WriteLine($"{n1} {symbol} {n2} = {sum} - {oddOrEven}");
            }
            else if (divide)
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    return;
                }
                sum = (n1 / n2);
                Console.WriteLine($"{n1} {symbol} {n2} = {sum:f2}");
            }
            else if (divideResidue)
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    return;
                }
                sum = n1 % n2;
                Console.WriteLine($"{n1} {symbol} {n2} = {sum}");
            }
        }
    }
}
