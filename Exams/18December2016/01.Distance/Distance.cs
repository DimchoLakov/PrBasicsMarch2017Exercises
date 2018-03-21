using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine()) / 60;
            double secondTime = double.Parse(Console.ReadLine()) / 60;
            double thirdTime = double.Parse(Console.ReadLine()) / 60;
            
            double firstSpeed = speed * firstTime;
            double speedPlus10 = speed + speed * 0.1;
            double secondSpeed = speedPlus10 * secondTime;
            double speedMinus5 = speedPlus10 - speedPlus10 * 0.05;
            double thirdSpeed = speedMinus5 * thirdTime;       
            double totalKm = firstSpeed + secondSpeed + thirdSpeed;
            Console.WriteLine($"{totalKm:f2}");
        }
    }
}
