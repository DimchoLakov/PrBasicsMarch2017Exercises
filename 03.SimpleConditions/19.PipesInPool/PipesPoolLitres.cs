using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.PipesInPool
{
    class PipesPoolLitres
    {
        static void Main(string[] args)
        {
            int totalVolume = int.Parse(Console.ReadLine());
            int pipeOne = int.Parse(Console.ReadLine());
            int pipeTwo = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double debitPipeOne = pipeOne * hours;
            double debitPipeTwo = pipeTwo * hours;
            double water = debitPipeOne + debitPipeTwo;

            int waterPercent = (int)((water / totalVolume) *100);
            int pipeOnePercent = (int)((debitPipeOne / water) * 100);
            int pipeTwoPercent = (int)((debitPipeTwo / water) * 100);
            if (water <= totalVolume)
            {                
                Console.WriteLine($"The pool is {waterPercent}% full. Pipe 1: {pipeOnePercent}%. Pipe 2: {pipeTwoPercent}%.");
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {(water-totalVolume)} liters."); 
            }

        }
    }
}
