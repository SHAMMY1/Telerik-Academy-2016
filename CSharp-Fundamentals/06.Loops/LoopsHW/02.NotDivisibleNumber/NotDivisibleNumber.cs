using System;

class NotDivisibleNumber
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numberN; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.Write(i + " ");
            }
        }
    }
}