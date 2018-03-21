using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysFirmHave = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            int oneWorkingDay = 8;
            int overtimeMaxHours = 2;
            double daysAvailable = daysFirmHave - daysFirmHave * 0.1;
            double workingHours = daysAvailable * oneWorkingDay;
            double overtime = overtimeWorkers * (overtimeMaxHours * daysFirmHave);
            double totalHours = workingHours + overtime;
            double diff = Math.Abs(Math.Floor(totalHours - hoursNeeded));
            if (totalHours >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{diff} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{diff} hours needed.");
            }
        }
    }
}
