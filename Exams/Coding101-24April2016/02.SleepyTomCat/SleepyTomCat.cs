using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            int notWorkingDays = int.Parse(Console.ReadLine());

            int holidaysPlay = notWorkingDays * 127;
            int workingDaysPlay = (365 - notWorkingDays) * 63;
            int totalPlayTIme = holidaysPlay + workingDaysPlay;            
            int diff = Math.Abs(totalPlayTIme - 30000);
            int hoursPlay = diff / 60;
            int minutesPlay = diff % 60;
            if (totalPlayTIme > 30000)
            {
                Console.WriteLine($"Tom will run away\n{hoursPlay} hours and {minutesPlay} minutes more for play");
            }
            else if (totalPlayTIme <= 30000)
            {
                Console.WriteLine($"Tom sleeps well\n{hoursPlay} hours and {minutesPlay} minutes less for play");
            }
        }
    }
}
