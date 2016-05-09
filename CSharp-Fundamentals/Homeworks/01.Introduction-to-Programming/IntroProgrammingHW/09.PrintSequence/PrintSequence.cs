using System;

class PrintSequence
{
    static void Main()
    {
        int membersCount = 10;

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

