using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            double allPeople = 0.0d;
            int car = 0;
            int microbus = 0;
            int smallBus = 0;
            int bigBus = 0;
            int train = 0;
            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                allPeople += people;
                if (people > 0 && people <= 5)
                {
                    car += people;
                }
                else if (people > 5 && people <= 12)
                {
                    microbus += people;
                }
                else if (people > 12 && people <= 25)
                {
                    smallBus += people;
                }
                else if (people > 25 && people <= 40)
                {
                    bigBus += people;
                }
                else if (people > 40)
                {
                    train += people;
                }
            }
            double carPercentage = car / allPeople * 100;
            double microbusPercentage = microbus / allPeople * 100;
            double smallBusPercentage = smallBus / allPeople * 100;
            double bigBusPercentage = bigBus / allPeople * 100;
            double trainPercentage = train / allPeople * 100;
            Console.WriteLine($"{carPercentage:f2}%\n{microbusPercentage:f2}%\n{smallBusPercentage:f2}%\n{bigBusPercentage:f2}%\n{trainPercentage:f2}%");
        }
    }
}
