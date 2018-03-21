using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class DailyProfit
    {
        static void Main(string[] args)
        {
            int workingDaysAMonth = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double dollarToLeva = double.Parse(Console.ReadLine());

            double oneMonthSalary = workingDaysAMonth * moneyPerDay;
            double oneYearSalary = oneMonthSalary * 12;
            double moneyWithBonus = oneYearSalary + oneMonthSalary * 2.5;
            double totalMoneyAfterTax = moneyWithBonus - (moneyWithBonus * 0.25);
            double moneyInLeva = totalMoneyAfterTax * dollarToLeva;
            double averageAday = moneyInLeva / 365;
            Console.WriteLine($"{averageAday:f2}");
        }
    }
}
