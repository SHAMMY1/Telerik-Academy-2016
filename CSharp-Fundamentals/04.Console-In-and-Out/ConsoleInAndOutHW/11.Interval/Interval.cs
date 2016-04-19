using System;

class Interval
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int numberM = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = numberN + 1; i < numberM; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
