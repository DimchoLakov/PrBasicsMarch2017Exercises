using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {            
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {n}");
                        break;
                    }
                    Console.WriteLine("The number is not even.");
                }
                catch (FormatException frmtExcpt)
                {
                    Console.WriteLine(frmtExcpt.Message);
                }
                catch (OverflowException overflowExcpt)
                {
                    Console.WriteLine(overflowExcpt.Message);
                }
            }
        }
    }
}
