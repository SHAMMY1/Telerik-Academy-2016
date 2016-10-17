using System;

class StringLength
{
    static void Main()
    {
        string theString = Console.ReadLine();

        Console.WriteLine(theString.PadRight(20, '*'));
    }
}

