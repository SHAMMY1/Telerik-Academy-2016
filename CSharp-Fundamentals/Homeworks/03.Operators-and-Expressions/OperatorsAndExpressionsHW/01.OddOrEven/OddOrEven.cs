using System;

class OddOrEven
{
    static void Main()
    {
        sbyte number = sbyte.Parse(Console.ReadLine());

        string oddMessage = "odd";
        string evenMessage = "even";

        bool isEven = number % 2 == 0;

        string messageToPrint = isEven ? evenMessage : oddMessage;

        Console.WriteLine("{0} {1}", messageToPrint, number);
    }
}

