using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class DistanceCar
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double firstTime = double.Parse(Console.ReadLine()) / 60;
            double secondTime = double.Parse(Console.ReadLine()) / 60;
            double thirdTime = double.Parse(Console.ReadLine()) / 60;

            double firstDistance = speed * firstTime;
            double speedPlus10 = speed + (speed * 0.1);
            double secondDistance = speedPlus10 * secondTime;
            double speedMinus5 = speedPlus10 - (speedPlus10 * 0.05);
            double thirdDistance = speedMinus5 * thirdTime;
            double total = firstDistance + secondDistance + thirdDistance;
            Console.WriteLine($"{total:f2}");
            
            
          
        }
    }
}
