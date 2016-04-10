using System;

class LongSequence
{
    static void Main()
    {
        int membersCount = 1000;

        for (int i = 0; i < membersCount; i++)
        {
            int numberToPrint = i + 2;

            if (i % 2 != 0)
            {
                numberToPrint *= -1;
            }

            Console.WriteLine(numberToPrint);
        }
    }
}

