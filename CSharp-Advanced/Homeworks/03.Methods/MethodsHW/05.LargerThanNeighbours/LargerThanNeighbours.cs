using System;
using System.Collections.Generic;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.ReadLine();

        string numbersAsString = Console.ReadLine();

        var numbers = numbersAsString.Split(' ').Select(int.Parse).ToArray();

        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsBigerThanNeighbors(numbers, i))
            {
                count ++;
            }
        }

        Console.WriteLine(count);
    }

    static bool IsBigerThanNeighbors(int[] numbers, int position)
    {
        if (position <= 0 || position >= numbers.Length - 1)
        {
            return false;
        }

        return (numbers[position] > numbers[position - 1]) && (numbers[position] > numbers[position + 1]);
    }
}
