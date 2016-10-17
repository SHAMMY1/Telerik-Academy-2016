using System;

class OddAndEvenProduct
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        long evenSum = 1;
        long oddSum = 1;

        string numbers = Console.ReadLine();

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                evenSum *= (long)char.GetNumericValue(numbers[i * 2]);
            }
            else
            {
                oddSum *= (long)char.GetNumericValue(numbers[i * 2]);
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("yes {0}", evenSum);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evenSum, oddSum);
        }
    }
}
