using System;

class AgeAddYears
{
    static void Main()
    {
        Console.WriteLine("What age are you?:");
        string AgeNow = Console.ReadLine();
        int num = int.Parse(AgeNow);
        DateTime AgeInTenYears = new DateTime(num, 1, 1);
        AgeInTenYears = AgeInTenYears.AddYears(10);
        Console.WriteLine("After 10 years you will be " + AgeInTenYears.Year + " years old.");
    }
}

/*
using System;
class Literals
{
    static void Main()
    {
        // Declare some variables
        int a = 1;
        int b = 2;
        // Which one is greater?
        bool greaterAB = (a > b);
        // Is 'a' equal to 1?
        bool equalA1 = (a == 1);
        // Print the results on the console
        if (greaterAB)
        {
            Console.WriteLine("A > B");
        }
        else
        {
            Console.WriteLine("A <= B");
        }
        Console.WriteLine("greaterAB = " + greaterAB);
        Console.WriteLine("equalA1 = " + equalA1);
        // Console output:
        // A <= B
        // greaterAB = False
        // equalA1 = True
    }
}
*/
