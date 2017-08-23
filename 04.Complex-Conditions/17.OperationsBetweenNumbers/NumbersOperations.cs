using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.OperationsBetweenNumbers
{
    class NumbersOperations
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            char opp = char.Parse(Console.ReadLine());
            double sum = numOne + numTwo;
            double difference = numOne - numTwo;
            double multiply = numOne * numTwo;            
            bool plus = opp == '+';
            bool minus = opp == '-';
            bool multi = opp == '*';
            bool div = opp == '/';
            bool diff = opp == '%';
            double result = 0.0d;          
            
            if (plus || minus || multi)
            {                
                if (plus)
                {
                    result = sum;
                    if (Math.Abs(result) % 2 == 0)
                    {
                        Console.WriteLine($"{numOne} {opp} {numTwo} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numOne} {opp} {numTwo} = {result} - odd");
                    }
                }
                else if (minus)
                {
                    result = difference;
                    if (Math.Abs(result) % 2 == 0)
                    {
                        Console.WriteLine($"{numOne} {opp} {numTwo} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numOne} {opp} {numTwo} = {result} - odd");
                    }
                }
                else if (multi)
                {
                    result = multiply;
                    if (Math.Abs(result) % 2 == 0)
                    {
                        Console.WriteLine($"{numOne} {opp} {numTwo} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{numOne} {opp} {numTwo} = {result} - odd");
                    }
                }                
            }
            else if (div)
            {
                if (numTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numOne} by zero");
                }
                else
                {
                    double divide = numOne / numTwo;
                    result = divide;
                    Console.WriteLine($"{numOne} {opp} {numTwo} = {result:f2}");
                }                                
            }
            else if (diff)
            {
                if (numTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numOne} by zero");
                }
                else
                {
                    double residue = numOne % numTwo;
                    result = residue;
                    Console.WriteLine($"{numOne} {opp} {numTwo} = {result}");
                }                
            }           
        }
    }
}
