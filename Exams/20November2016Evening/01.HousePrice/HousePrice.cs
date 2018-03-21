﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HousePrice
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            double smallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double pricePerSqMeter = double.Parse(Console.ReadLine());
            double bathroom = smallestRoom / 2;
            double secondRoom = smallestRoom + smallestRoom * 0.1;
            double thirdRoom = secondRoom + secondRoom * 0.1;
            double area = smallestRoom + kitchen + bathroom + secondRoom + thirdRoom;
            double totalArea = area + area * 0.05;
            double price = totalArea * pricePerSqMeter;
            Console.WriteLine($"{price:f2}");
        }
    }
}
