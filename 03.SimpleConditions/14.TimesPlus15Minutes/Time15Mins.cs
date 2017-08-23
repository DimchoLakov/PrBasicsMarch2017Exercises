using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.TimesPlus15Minutes
{
    class Time15Mins
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;

                if (hours >= 24)
                {
                    hours = 0;
                }
            }
            Console.WriteLine($"{hours}:{minutes:00}");
        }
    }
}
