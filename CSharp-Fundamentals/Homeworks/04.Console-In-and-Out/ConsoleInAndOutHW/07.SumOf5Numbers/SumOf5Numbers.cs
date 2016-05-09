using System;

class SumOf5Numbers
{
    static void Main()
    {
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            sum += currentNumber;
        }

        Console.WriteLine(sum);
    }
}