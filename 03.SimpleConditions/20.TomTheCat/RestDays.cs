using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.TomTheCat
{
    class RestDays
    {
        static void Main(string[] args)
        {
            int restingDays = int.Parse(Console.ReadLine());

            int holidays = restingDays * 127;
            int workingDays = (365 - restingDays) * 63;
            int totalPlayHours = holidays + workingDays;
            int tomNorm = 30000;
            
            if (totalPlayHours > tomNorm)
            {
                int differenceInHours = Math.Abs((tomNorm - totalPlayHours) / 60);
                int differenceinMinutes = Math.Abs((tomNorm - totalPlayHours) % 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{differenceInHours} hours and {differenceinMinutes} minutes more for play");
            }
            else if (totalPlayHours < tomNorm)
            {
                int differenceInHours = Math.Abs((totalPlayHours - tomNorm) / 60);
                int differenceinMinutes = Math.Abs((totalPlayHours - tomNorm) % 60);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{differenceInHours} hours and {differenceinMinutes} minutes less for play");
            }


        }
    }
}
