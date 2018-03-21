using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            double months = double.Parse(Console.ReadLine());
            double electricity = 0.0d;
            double water = 20;
            double internet = 15;
            double others = 0.0d;            
            for (int i = 0; i < months; i++)
            {
                double electricityPerMonth = double.Parse(Console.ReadLine());
                electricity += electricityPerMonth;                
                others += (electricityPerMonth + water + internet) + ((electricityPerMonth + water + internet) * 0.2);
            }            
            double average = (others + electricity + (water*months) + (internet*months)) / months;
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water*months:f2} lv");
            Console.WriteLine($"Internet: {internet*months:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
