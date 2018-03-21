using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int loads = int.Parse(Console.ReadLine());
            double microbusPrice = 200d;
            double truckPrice = 175d;
            double trainPrice = 120d;
            int microbus = 0;
            int truck = 0;
            int train = 0;
            double totalTons = 0.0d;
            for (int i = 0; i < loads; i++)
            {
                int singleLoad = int.Parse(Console.ReadLine());
                if (singleLoad > 0 && singleLoad <= 3)
                {
                    microbus += singleLoad;
                }
                else if (singleLoad > 3 && singleLoad <= 11)
                {
                    truck += singleLoad;
                }
                else if (singleLoad > 11)
                {
                    train += singleLoad;
                }
                totalTons += singleLoad;
            }
            double average = (microbus * microbusPrice + truck * truckPrice + train * trainPrice) / totalTons;
            double microbusPercentage = microbus / totalTons * 100;
            double truckPercentage = truck / totalTons * 100;
            double trainPercentage = train / totalTons * 100;
            Console.WriteLine($"{average:f2}\n{microbusPercentage:f2}%\n{truckPercentage:f2}%\n{trainPercentage:f2}%");
        }
    }
}
