using System;

class MutantSquirrels
{
    static void Main()
    {
        long tails = long.Parse(Console.ReadLine()) * long.Parse(Console.ReadLine()) * long.Parse(Console.ReadLine()) * long.Parse(Console.ReadLine());

        if (tails % 2 == 0)
        {
            Console.WriteLine("{0:F3}", (double)tails * 376439);

        }
        else
        {
            Console.WriteLine("{0:F3}", (double)tails / 7);
        }
    }
}

