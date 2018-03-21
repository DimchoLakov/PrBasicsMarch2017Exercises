using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeTiles
{
    class Tiles
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLenght = double.Parse(Console.ReadLine());
            double sideTriangle = double.Parse(Console.ReadLine());
            double heightTriangle = double.Parse(Console.ReadLine());
            double oneTilePrice = double.Parse(Console.ReadLine());
            double workman = double.Parse(Console.ReadLine());

            double floorArea = floorWidth * floorLenght;
            double tileArea = (sideTriangle * heightTriangle) / 2;
            double tilesNeeded = Math.Ceiling((floorArea / tileArea)) + 5;
            double total = (tilesNeeded * oneTilePrice) + workman;
            double moneyLeft = money - total;
            double moneeNotEnough = total - money;
            if (total <= money)
            {
                Console.WriteLine($"{moneyLeft:f2} lv left.");
            }
            else if (total > money)
            {
                Console.WriteLine($"You'll need {moneeNotEnough:f2} lv more.");
            }
        }
    }
}
