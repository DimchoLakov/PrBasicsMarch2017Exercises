using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SchoolCamp
{
    class SchoolCamp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string boysGirlsOrMixed = Console.ReadLine().ToLower();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string sportType = null;
            double price = 0.0d;

            if (season == "winter" && boysGirlsOrMixed == "girls" || boysGirlsOrMixed == "boys" && season == "winter")
            {
                price = 9.6;
            }
            else if (season == "winter" && boysGirlsOrMixed == "mixed")
            {
                price = 10.0;
            }
            else if (season == "spring" && boysGirlsOrMixed == "girls" || boysGirlsOrMixed == "boys" && season == "spring")
            {
                price = 7.2;
            }
            else if (season == "spring" && boysGirlsOrMixed == "mixed")
            {
                price = 9.5;
            }
            else if (season == "summer" && boysGirlsOrMixed == "girls" || boysGirlsOrMixed == "boys" && season == "summer")
            {
                price = 15.0;
            }
            else if (season == "summer" && boysGirlsOrMixed == "mixed")
            {
                price = 20.0;
            }

            double totalPrice = price * nights * students;

            if (students >= 50)
            {
                totalPrice = totalPrice - (totalPrice * 0.5);
            }
            else if (students >= 20 && students < 50)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            else if (students >= 10 && students < 20)
            {
                totalPrice = totalPrice - (totalPrice * 0.05);
            }

            if (season == "winter")
            {
                if (boysGirlsOrMixed == "girls")
                {
                    sportType = "Gymnastics";
                }
                else if (boysGirlsOrMixed == "boys")
                {
                    sportType = "Judo";
                }
                else if (boysGirlsOrMixed == "mixed")
                {
                    sportType = "Ski";
                }
            }
            else if (season == "spring")
            {
                if (boysGirlsOrMixed == "girls")
                {
                    sportType = "Athletics";
                }
                else if (boysGirlsOrMixed == "boys")
                {
                    sportType = "Tennis";
                }
                else if (boysGirlsOrMixed == "mixed")
                {
                    sportType = "Cycling";
                }
            }
            else if (season == "summer")
            {
                if (boysGirlsOrMixed == "girls")
                {
                    sportType = "Volleyball";
                }
                else if (boysGirlsOrMixed == "boys")
                {
                    sportType = "Football";
                }
                else if (boysGirlsOrMixed == "mixed")
                {
                    sportType = "Swimming";
                }
            }
            Console.WriteLine($"{sportType} {totalPrice:f2} lv.");
        }
    }
}
