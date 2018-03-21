using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0.0d;
            double priceFlat = 0.0d;
            if (nights > 0 && nights <= 7)
            {
                if (month == "may" || month == "october")
                {
                    priceStudio = nights * 50;
                    priceFlat = nights * 65;
                }
                else if (month == "june" || month == "september")
                {
                    priceStudio = nights * 75.2;
                    priceFlat = nights * 68.7;
                }
                else if (month == "july" || month == "august")
                {
                    priceStudio = nights * 76;
                    priceFlat = nights * 77;
                }
            }
            else if (nights > 7 && nights <= 14)
            {
                if (month == "may" || month == "october")
                {
                    priceStudio = nights * 50 - ((nights * 50) * 0.05 );
                    priceFlat = nights * 65;
                }
                else if (month == "june" || month == "september")
                {
                    priceStudio = nights * 75.2;
                    priceFlat = nights * 68.7;
                }
                else if (month == "july" || month == "august")
                {
                    priceStudio = nights * 76;
                    priceFlat = nights * 77;
                }
            }
            else if (nights > 14)
            {
                if (month == "may" || month == "october")
                {
                    priceStudio = nights * 50 - ((nights * 50) * 0.3);
                    priceFlat = nights * 65 - ((nights * 65) * 0.1);
                }
                else if (month == "june" || month == "september")
                {
                    priceStudio = nights * 75.2 - ((nights * 75.2) * 0.2);
                    priceFlat = nights * 68.7 - ((nights * 68.7) * 0.1);
                }
                else if (month == "july" || month == "august")
                {
                    priceStudio = nights * 76;
                    priceFlat = nights * 77 - ((nights * 77) * 0.1);
                }
            }
            Console.WriteLine($"Apartment: {priceFlat:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
