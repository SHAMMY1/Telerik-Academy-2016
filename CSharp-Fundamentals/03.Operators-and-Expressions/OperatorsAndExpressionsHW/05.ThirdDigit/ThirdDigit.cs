using System;

class ThirdDigit
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        uint thirdDigit = (number / 100) % 10;

        bool isThirdDigitSeven = thirdDigit == 7;

        Console.Write(isThirdDigitSeven.ToString().ToLower());

        if (!isThirdDigitSeven)
        {
            Console.WriteLine(" {0}", thirdDigit);
        }
    }
}
