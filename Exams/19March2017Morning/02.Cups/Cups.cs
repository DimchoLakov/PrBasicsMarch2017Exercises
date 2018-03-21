using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cups
{
    class Cups
    {
        static void Main(string[] args)
        {
            int cupsPlanned = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            
            double workingHours = workers * workingDays * 8;
            double cupsMade = Math.Floor(workingHours / 5);
            double cupsNotEnough = cupsPlanned - cupsMade;
            double cupsMore = cupsMade - cupsPlanned;
            double losses = cupsNotEnough * 4.2;
            double profit = cupsMore * 4.2;
            if (cupsMade < cupsPlanned)
            {
                Console.WriteLine("Losses: {0:f2}", losses);
            }
            else if (cupsMade >= cupsPlanned)
            {
                Console.WriteLine("{0:f2} extra money", profit);
            }

        }
    }
}
