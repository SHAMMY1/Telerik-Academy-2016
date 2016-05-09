using System;

class NthBit
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        bool isNthBitZero = (((long)1 << n) & number) == 0;

        Console.WriteLine(isNthBitZero ? "0" : "1");
    }
}

