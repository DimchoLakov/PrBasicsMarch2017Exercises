using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BonusPoints
{
    class BonusPts
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0d;

            if (number <= 100)
            {
                bonusPoints += 5;
            }
            else if (number > 100 && number <= 1000)
            {
                bonusPoints = number * 0.2;
            }
            else if (number > 1000)
            {
                bonusPoints = number * 0.1;
            }

            if (number % 2 == 0)
            {
                bonusPoints += 1;
            }
            else if (number % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine($"{bonusPoints} bonus points");
            Console.WriteLine($"{ number + bonusPoints} total points");
        }
    }
}
