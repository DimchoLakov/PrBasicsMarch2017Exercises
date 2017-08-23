using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ClassRoom
{
    class SeatsInClassRoom
    {
        static void Main(string[] args)
        {
            #region Option 1
            //double length = double.Parse(Console.ReadLine()) * 100;
            //double width = double.Parse(Console.ReadLine()) * 100;
            //double columns = Math.Truncate(length / 120);
            //double rows = Math.Truncate((width - 100) / 70);
            //double seats = (columns * rows) - 3;
            //Console.WriteLine(seats);
            #endregion

            #region Option 2
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double h = length *100;
            double w = width * 100;
            double rows = (int)h / 120;
            double tables = (int)(w - 100) / 70;
            double seats = (rows * tables) - 3;
            Console.WriteLine(seats);



            #endregion
        }
    }
}
