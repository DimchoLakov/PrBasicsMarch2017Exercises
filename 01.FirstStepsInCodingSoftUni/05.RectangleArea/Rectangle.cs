using System;

namespace RectangleArea
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            var a = Decimal.Parse(Console.ReadLine());
            var b = Decimal.Parse(Console.ReadLine());
            Console.WriteLine(a * b);
        }
    }
}
