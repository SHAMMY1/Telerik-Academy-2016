using System;

class DivideBy7And5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isDividedBy7 = (number % 7) == 0;
        bool isDividedBy5 = (number % 5) == 0;

        bool isDividedBy7And5 = isDividedBy7 && isDividedBy5;

        string messageToPrint = isDividedBy7And5.ToString().ToLower();

        Console.WriteLine("{0} {1}", messageToPrint, number);
    }
}
