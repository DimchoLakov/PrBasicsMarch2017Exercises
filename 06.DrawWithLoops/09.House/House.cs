using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //(n + 1) / 2  --> i = 1 and i <= 
            //or
            //(n + 1) / 2 - 1 --> i = 0 and i <

            //n / 2 + n % 2

            #region House roof

            int numberOfRows = (n + 1) / 2;
            int numberOfStars = 0;
            if (n % 2 == 0)
            {
                numberOfStars = 2;
            }
            else
            {
                numberOfStars = 1;
            }

            for (int i = 1; i <= numberOfRows; i++)
            {
                int numberOfDashes = (n - numberOfStars) / 2;
                Console.Write(new string('-', numberOfDashes));
                Console.Write(new string('*', numberOfStars));
                Console.WriteLine(new string('-', numberOfDashes));
                numberOfStars += 2;
            }

            #endregion


            #region House body

            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
            
            #endregion
        }
    }
}
