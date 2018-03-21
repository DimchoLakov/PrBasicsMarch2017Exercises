using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            double volumePool = double.Parse(Console.ReadLine());
            int pipeOneDebitPerHour = int.Parse(Console.ReadLine());
            int pipeTwoDebitPerHour = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double pipeOneDebit = pipeOneDebitPerHour * hours;
            double pipeTwoDebit = pipeTwoDebitPerHour * hours;
            double waterInPool = pipeOneDebit + pipeTwoDebit;
            double poolNotFull = waterInPool / volumePool * 100;
            double pipeOnePercentage = pipeOneDebit / waterInPool * 100;
            double pipeTwoPercentage = pipeTwoDebit / waterInPool * 100;
            double diff = Math.Abs(volumePool - waterInPool);

            if (waterInPool <= volumePool)
            {
                Console.WriteLine($"The pool is {(int)poolNotFull}% full. Pipe 1: {(int)pipeOnePercentage}%. Pipe 2: {(int)pipeTwoPercentage}%.");
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {diff} liters.");
            }     
        }
    }
}
