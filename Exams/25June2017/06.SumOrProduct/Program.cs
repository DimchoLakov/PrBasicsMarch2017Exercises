using System;

namespace _06.SumOrProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        if (i < j && j < k)
                        {
                            if (i + j + k == controlNumber)
                            {
                                Console.WriteLine($"{i} + {j} + {k} = {controlNumber}");
                                isFound = true;
                            }
                        }
                        else if (i > j && j > k)
                        {
                            if (i * j * k == controlNumber)
                            {
                                Console.WriteLine($"{i} * {j} * {k} = {controlNumber}");
                                isFound = true;
                            }
                        }

                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"No!");
            }
        }
    }
}
