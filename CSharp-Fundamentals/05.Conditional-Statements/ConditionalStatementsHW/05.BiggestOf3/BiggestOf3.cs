using System;

class BiggestOf3
{
    static void Main()
    {
        int numbersCount = 3;

        int biggestNumber = int.MinValue;

        for (int i = 0; i < numbersCount; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            if (currentNumber > biggestNumber)
            {
                biggestNumber = currentNumber;
            }
        }

        Console.WriteLine(biggestNumber);
    }
}

