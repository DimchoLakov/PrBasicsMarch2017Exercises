using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.HotelRoom
{
    class Rooms
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());
            
            double priceForApartment = 0.0d;
            double priceForStudio = 0.0d;
            if (month == "may" || month == "october")
            {                
                if (nights > 0 && nights <= 7)
                {
                    priceForStudio = 50 * nights;
                    priceForApartment = 65 * nights;                    
                }
                else if (nights > 7 && nights <= 14)
                {
                    priceForStudio = (nights * 50) - ((nights * 50) * 0.05);
                    priceForApartment = 65 * nights;
                }
                else if (nights > 14)
                {
                    priceForStudio = (nights * 50) - ((nights * 50) * 0.3);
                    priceForApartment = 65 * nights - (0.1 * (65 * nights));
                }
            }
            else if (month == "june" || month == "september")
            {
                if (nights > 0 && nights <= 14)
                {
                    priceForStudio = 75.2 * nights;
                    priceForApartment = 68.7 * nights;
                }
                else if (nights > 14)
                {
                    priceForStudio = (75.2 * nights) - ((75.2 * nights) * 0.2);
                    priceForApartment = (68.7 * nights) - ((68.7 * nights) * 0.1);
                }
            }
            else if (month == "july" || month == "august")
            {
                if (nights > 0 && nights <= 14)
                {
                    priceForStudio = nights * 76;
                    priceForApartment = nights * 77;
                }
                else if (nights > 14)
                {
                    priceForStudio = nights * 76;
                    priceForApartment = nights * 77 - ((nights * 77) * 0.1);
                }
            }
            Console.WriteLine($"Apartment: {priceForApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio:f2} lv.");            
        }
    }
}
