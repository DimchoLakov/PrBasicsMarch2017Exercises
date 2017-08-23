using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string moneyToConvert = Console.ReadLine().ToUpper();
            string convertedCurrency = Console.ReadLine().ToUpper();
            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;
            double result = 0.0;

            if (moneyToConvert == "USD")
            {
                result = money * usd;
            }
            else if (moneyToConvert == "EUR")
            {
                result = money * eur;
            }
            else if (moneyToConvert == "GBP")
            {
                result = money * gbp;
            }
            else if (moneyToConvert == "BGN")
            {
                result = money;
            }

            if (convertedCurrency == "USD")
            {
                result = result / usd;
            }
            else if (convertedCurrency == "EUR")
            {
                result = result / eur;
            }
            else if (convertedCurrency == "GBP")
            {
                result = result / gbp;
            }

            Console.WriteLine($"{result:f2} {convertedCurrency}");
        }
    }
}
