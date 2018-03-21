using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ToyShop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int fluffyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int allToys = puzzles + dolls + fluffyBears + minions + trucks;

            double puzzlesPrice = puzzles * 2.6;
            double dollsPrice = dolls * 3.0;
            double bearsPrice = fluffyBears * 4.1;
            double minionsPrice = minions * 8.2;
            double trucksPrice = trucks * 2.0;
            double totalPrice = dollsPrice + puzzlesPrice + bearsPrice + minionsPrice + trucksPrice;
            
            if (allToys >= 50)
            {
                totalPrice = totalPrice - (totalPrice * 0.25);
            }
            totalPrice = totalPrice - (totalPrice * 0.1);
            double diff = Math.Abs(totalPrice - holidayPrice);
            if (totalPrice >= holidayPrice)
            {
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diff:f2} lv needed.");
            }
        }
    }
}
