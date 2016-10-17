using System;
using System.Collections.Generic;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.ReadLine();

        string numbersAsString = Console.ReadLine();

        var numbers = numbersAsString.Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(IndexOfFirstLargerThanNeighbours(numbers));
    }

    static int IndexOfFirstLargerThanNeighbours(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsBigerThanNeighbors(numbers, i))
            {
                return i;
            }
        }

        return -1;
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

