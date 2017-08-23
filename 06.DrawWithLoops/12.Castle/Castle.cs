using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Castle
{
    class Castle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int specialSymbol = (2 * n) - 2 * (n / 2) - 4; // От цялата дължина "2 * n" вадим ДВЕТЕ вътрешни колони (всяка, от които е = n / 2) "2 * (n / 2)" и накрая вадим 4-те статични крайни символа "/" и "\" "
            
            #region Top Line
            Console.Write("/" + new string('^', n / 2) + "\\");           
            for (int i = 0; i < specialSymbol; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("/" + new string('^', n / 2) + "\\");                       
            #endregion

            #region Middle

            for (int row = 0; row < n - 3; row++)
            {
                Console.WriteLine("|" + new string(' ', (2 * n) - 2) + "|");
            }
            Console.WriteLine("|" + new string(' ', n / 2 + 1) + new string('_', specialSymbol) + new string(' ', n / 2 + 1) + "|");
            #endregion

            #region Bottom Line
            Console.Write("\\" + new string('_', n / 2) + "/");
            for (int i = 0; i < specialSymbol; i++)
            {
                Console.Write(" ");
            }
            Console.Write("\\" + new string('_', n / 2) + "/");
            #endregion
        }
    }
}
