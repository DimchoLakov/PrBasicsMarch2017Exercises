using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumSeconds
{
    class SecondsThreePlayers
    {
        static void Main(string[] args)
        {
            #region FirstOption
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int thirdPlayer = int.Parse(Console.ReadLine());

            int seconds = firstPlayer + secondPlayer + thirdPlayer;
            int minutes = seconds / 60;
            if (seconds >= 1 && seconds <= 59)
            {
                Console.WriteLine("{0}:{1:00}", minutes, seconds);
            }
            else if (seconds > 59 && seconds <= 119)
            {
                Console.WriteLine("{0}:{1:00}", minutes, seconds - 60);
            }
            else if (seconds > 119 && seconds <= 179)
            {
                Console.WriteLine("{0}:{1:00}", minutes, seconds - 120);
            }
            #endregion

            #region SecondOption




            //int firstSeconds = int.Parse(Console.ReadLine());
            //int secondSeconds = int.Parse(Console.ReadLine());
            //int thridSeconds = int.Parse(Console.ReadLine());

            //// We sum all the SECONDS into one variable to find TOTAL SECONDS
            //int totalSeconds = (firstSeconds + secondSeconds + thridSeconds);

            //// We divide TOTAL SECONDS to 60 to find how many MINUTES we've got
            //int minutes = totalSeconds / 60;

            //// We divide Total SECONDS to % 60 to find how many SECONDS we've got left 
            //int leftSeconds = totalSeconds % 60;
            //Console.WriteLine($"{minutes}:{leftSeconds:00}");
            //if (leftSeconds >= 10)
            //{
            //    Console.WriteLine($"{minutes}:{leftSeconds}");
            //}
            //else
            //{
            //    Console.WriteLine($"{minutes}:0{leftSeconds}");
            //}




            #endregion

        }
    }
}
