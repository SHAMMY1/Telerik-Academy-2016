using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberN; i++)
        {
            Console.WriteLine(i);
        }
    }
}
