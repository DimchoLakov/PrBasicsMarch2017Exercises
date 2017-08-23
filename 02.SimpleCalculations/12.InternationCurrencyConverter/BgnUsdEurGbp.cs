using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationCurrencyConverter
{
    class BgnUsdEurGbp
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter amount:");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("Currency from:");       
            string currencyToConvert = Console.ReadLine().ToLower();
            Console.Write("To:");
            string convertedCurrency = Console.ReadLine().ToLower();
                        
            if (currencyToConvert == "usd")
            {
                if (convertedCurrency == "bgn")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount * 1.79549m, 2), convertedCurrency);
                }
                else if (convertedCurrency == "eur")
                {
                    Console.WriteLine("{0 {1}", Math.Round(amount * 0.91801m, 2), convertedCurrency);
                }
                else if (convertedCurrency == "gbp")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount * 2.53405m, 2), convertedCurrency);
                }
            }
            if (currencyToConvert == "bgn")
            {
                if (convertedCurrency == "usd")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount / 1.79549m, 2), convertedCurrency);
                }
                else if (convertedCurrency == "eur")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount / 1.95583m, 2), convertedCurrency);
                }
                else if (convertedCurrency == "gbp")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount / 2.53405m, 2), convertedCurrency);
                }
            }
            if (currencyToConvert == "eur")
            {
                if (convertedCurrency == "bgn")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount / 0.51129m, 2), convertedCurrency);
                }
                else if (convertedCurrency == "gbp")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount * 0.77181m, 2), convertedCurrency);
                }
                else if (convertedCurrency == "usd")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount * 0.77181m, 2), convertedCurrency);
                }
            }
            if (currencyToConvert == "gbp")
            {
                if (convertedCurrency == "bgn")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount * 2.53405m, 2), convertedCurrency);
                }
                else if (convertedCurrency == "eur")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount * 1.29563m, 2), convertedCurrency);
                }
                else if (convertedCurrency == "usd")
                {
                    Console.WriteLine("{0} {1}", Math.Round(amount * 1.41134m, 2), convertedCurrency);
                }
            }

        }
    }
}
