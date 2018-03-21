using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RepairingTheTiles
{
    class RepairingTheTiles
    {
        static void Main(string[] args)
        {
            int nPlaygroundSide = int.Parse(Console.ReadLine());
            double wTile = double.Parse(Console.ReadLine());
            double hTile = double.Parse(Console.ReadLine());
            double wBench = double.Parse(Console.ReadLine());
            double hBench = double.Parse(Console.ReadLine());

            double playgroundArea = nPlaygroundSide * nPlaygroundSide;
            double oneTileArea = wTile * hTile;
            double benchArea = wBench * hBench;
            double tilesArea = playgroundArea - benchArea;
            double tilesNeeded = tilesArea / oneTileArea;
            double timeForTiles = tilesNeeded * 0.2;
            Console.WriteLine(tilesNeeded);
            Console.WriteLine(timeForTiles);
        }
    }
}
