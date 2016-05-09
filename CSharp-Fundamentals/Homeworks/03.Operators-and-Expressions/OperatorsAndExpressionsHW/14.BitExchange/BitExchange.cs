using System;
class BitExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        {
            uint rightMask = (uint)1 << (i + 3);
            uint leftMask = (uint)1 << (i + 24);

            uint leftBit = number & leftMask;
            uint rightBit = number & rightMask;

            number = number & (~rightMask);
            number = number & (~leftMask);

            number = number | (leftBit >> 21);
            number = number | (rightBit << 21);
        }

        Console.WriteLine(number);
    }
}

