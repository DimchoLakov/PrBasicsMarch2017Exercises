using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLlily
{
    class SmartLlily
    {
        static void Main(string[] args)
        {
            int ageLily = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toysCount = 0;
            int bonus = 10;
            int stolenMoney = 0;
            double sum = 0.0d;

            for (int birthday = 1; birthday <= ageLily; birthday++)
            {                
                if (birthday % 2 == 0)
                {
                    sum += bonus;
                    bonus += 10;
                    stolenMoney++;
                }
                else
                {
                    toysCount++;
                }
            }
            double savedMoney = sum + (toysCount * toyPrice) - stolenMoney;
            double diff = Math.Abs(savedMoney - washingMachinePrice);
            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
