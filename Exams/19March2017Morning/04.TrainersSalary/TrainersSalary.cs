using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TrainersSalary
{
    class TrainersSalary
    {
        static void Main(string[] args)
        {
            double lections = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double jelev = 0.0d;
            double royal = 0.0d;
            double roli = 0.0d;
            double trofon = 0.0d;
            double sino = 0.0d;
            double others = 0.0d;

            for (int i = 0; i < lections; i++)
            {
                string lector = Console.ReadLine();
                if (lector == "Jelev")
                {
                    jelev++;
                }
                else if (lector == "RoYaL")
                {
                    royal++;
                }
                else if (lector == "Roli")
                {
                    roli++;
                }
                else if (lector == "Trofon")
                {
                    trofon++;
                }
                else if (lector == "Sino")
                {
                    sino++;
                }
                else
                {
                    others++;
                }
            }
            double money = budget / lections;
            Console.WriteLine($"Jelev salary: {jelev*money:f2} lv");
            Console.WriteLine($"RoYaL salary: {royal * money:f2} lv");
            Console.WriteLine($"Roli salary: {roli * money:f2} lv");
            Console.WriteLine($"Trofon salary: {trofon * money:f2} lv");
            Console.WriteLine($"Sino salary: {sino * money:f2} lv");
            Console.WriteLine($"Others salary: {others * money:f2} lv");

        }
    }
}
