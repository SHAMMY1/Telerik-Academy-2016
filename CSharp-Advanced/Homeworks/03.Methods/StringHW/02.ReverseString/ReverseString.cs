using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        string theString = Console.ReadLine();
        string reverseString = new string(theString.Reverse().ToArray());

        Console.WriteLine(reverseString);
    }
}

