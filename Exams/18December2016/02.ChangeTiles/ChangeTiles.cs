using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double savedMoney = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double tileSide = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            double priceForOneTile = double.Parse(Console.ReadLine());
            double workerSalary = double.Parse(Console.ReadLine());

            double floorArea = floorWidth * floorLength;
            double tileArea = tileSide * tileHeight / 2;
            double tilesNeeded = (Math.Ceiling(floorArea / tileArea)) + 5;
            double tilesPrice = (tilesNeeded * priceForOneTile) + workerSalary;
            double diff = Math.Abs(tilesPrice - savedMoney);

            if (tilesPrice <= savedMoney)
            {
                Console.WriteLine($"{diff:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {diff:f2} lv more.");
            }
        }
    }
}
