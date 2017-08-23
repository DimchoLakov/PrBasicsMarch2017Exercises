using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.DailyProfit
{
    class Profit
    {
        static void Main(string[] args)
        {
            int workingDaysAMonth = int.Parse(Console.ReadLine());
            double earnedMoneyADay = double.Parse(Console.ReadLine());
            double dollarToLev = double.Parse(Console.ReadLine());

            double monthlySalary = workingDaysAMonth * earnedMoneyADay;
            double bonusMoney = monthlySalary * 2.5;
            double annualSalary = (monthlySalary * 12) + bonusMoney;
            double afterTaxMoney = annualSalary - (annualSalary * 0.25);
            double salaryToLeva = afterTaxMoney * dollarToLev;
            double dailyWages = salaryToLeva / 365;
            Console.WriteLine(Math.Round(dailyWages, 2));
            

        }
    }
}
