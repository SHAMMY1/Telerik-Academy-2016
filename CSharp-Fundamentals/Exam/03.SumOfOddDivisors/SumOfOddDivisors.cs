using System;

class SumOfOddDivisors
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int last = int.Parse(Console.ReadLine());
        int sum = 0;

        while (first <= last)
        {
            for (int i = 1; i <= first; i++)
            {
                bool isDivisor = (first % i == 0);
                bool isOdd = (i % 2 != 0);

                if (isDivisor &&  isOdd)
                {
                    sum += i;
                }
            }

            first++;
        }

        Console.WriteLine(sum);
    }
}

