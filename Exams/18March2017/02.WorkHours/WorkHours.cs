using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            int workingHours = workers * workingDays * 8;
            int diff = Math.Abs(workingHours - neededHours);
            int penalties = diff * workingDays;
            if (workingHours >= neededHours)
            {
                Console.WriteLine($"{diff} hours left");
            }
            else
            {
                Console.WriteLine($"{diff} overtime\nPenalties: {penalties}");
            }
        }
    }
}
