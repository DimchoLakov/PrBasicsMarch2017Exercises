using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            double magnolii = double.Parse(Console.ReadLine()) * 3.25;
            double ziumbiuli = double.Parse(Console.ReadLine()) * 4;
            double rozi = double.Parse(Console.ReadLine()) * 3.5;
            double kaktusi = double.Parse(Console.ReadLine()) * 8;
            double giftPrice = double.Parse(Console.ReadLine());

            double price = magnolii + ziumbiuli + rozi + kaktusi;
            double finalPrice = price - price * 0.05;
            double diff = Math.Abs(finalPrice - giftPrice);

            if (finalPrice >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(diff)} leva.");
            }   
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(diff)} leva.");
            }
        }
    }
}
