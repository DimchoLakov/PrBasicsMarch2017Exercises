using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battle
{
    class Battles
    {
        static void Main(string[] args)
        {
            int firstPlayerPokemons = int.Parse(Console.ReadLine());
            int secondPlayerPokemons = int.Parse(Console.ReadLine());
            int maxFights = int.Parse(Console.ReadLine());
            int moves = 0;
            for (int p1 = 1; p1 <= firstPlayerPokemons; p1++)
            {
                for (int p2 = 1; p2 <= secondPlayerPokemons; p2++)
                {
                    Console.Write($"({p1} <-> {p2}) ");
                    moves++;
                    if (moves == maxFights)
                    {
                        return;
                    }
                }
            }
        }
    }
}
