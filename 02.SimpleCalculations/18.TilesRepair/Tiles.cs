using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TilesRepair
{
    class Tiles
    {
        static void Main(string[] args)
        {
            
            int squareSide = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileLength = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());

            int squareArea = squareSide * squareSide;
            double oneTileArea = tileWidth * tileLength;
            int benchArea = benchWidth * benchLength;
            int areaForTiles = squareArea - benchArea;
            double tilesNeeded = areaForTiles / oneTileArea;
            double timeNeeded = tilesNeeded * 0.2;            
            Console.WriteLine($"Tiles needed:{tilesNeeded}");
            Console.WriteLine($"Time needed:{timeNeeded}");



        }
    }
}
