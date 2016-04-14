using System;

class ThirdBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isThirdBitZero = (number & (1 << 3)) == 0;

        Console.WriteLine(isThirdBitZero ? "0" : "1");
    }
}

