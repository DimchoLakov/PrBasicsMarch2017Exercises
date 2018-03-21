using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EncodedAnswers
{
    class EncodedAnswers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            uint a = 0;
            uint b = 0;
            uint c = 0;
            uint d = 0;
            string result = null;
            string abcd = null;
            for (int i = 0; i < n; i++)
            {
                uint numbers = uint.Parse(Console.ReadLine());
                if (numbers % 4 == 0)
                {
                    a++;
                    abcd = "a";
                }
                else if (numbers % 4 == 1)
                {
                    b++;
                    abcd = "b";
                }
                else if (numbers % 4 == 2)
                {
                    c++;
                    abcd = "c";
                }
                else if (numbers % 4 == 3)
                {
                    d++;
                    abcd = "d";
                }
                result += abcd + " ";
            }
            Console.WriteLine(result);
            Console.WriteLine($"Answer A: {a}\nAnswer B: {b}\nAnswer C: {c}\nAnswer D: {d}");           
        }
    }
}
