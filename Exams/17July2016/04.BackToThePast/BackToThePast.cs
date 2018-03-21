using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            int ageIvan = 18;
            for (int year = 1800; year <= yearToLive; year++)
            {
                if (year % 2 == 0)
                {
                    inheritedMoney -= 12000;
                }
                else
                {
                    inheritedMoney -= 12000 + (ageIvan * 50);
                }
                ageIvan++;
            }
            if (inheritedMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {Math.Abs(inheritedMoney):f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
        }
    }
}
