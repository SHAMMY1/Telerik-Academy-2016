using System;

class BitSwap
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int numberP = int.Parse(Console.ReadLine());
        int numberQ = int.Parse(Console.ReadLine());
        uint numberK = uint.Parse(Console.ReadLine());
        int diferents =(int)Math.Abs(numberP - numberQ);

        for (int i = 0; i < numberK; i++)
        {
            uint rightMask = (uint)1 << (i + numberP);
            uint leftMask = (uint)1 << (i + numberQ);

            uint leftBit = number & leftMask;
            uint rightBit = number & rightMask;

            number = number & (~rightMask);
            number = number & (~leftMask);

            number = number | (leftBit >> diferents);
            number = number | (rightBit << diferents);
        }

        Console.WriteLine(number);
    }
}

