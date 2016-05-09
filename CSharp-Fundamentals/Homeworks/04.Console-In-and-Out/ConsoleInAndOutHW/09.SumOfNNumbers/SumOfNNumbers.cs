using System;

class SumOfNNumbers
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < numberN; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            sum += currentNumber;
        }

        Console.WriteLine(sum);
    }
}