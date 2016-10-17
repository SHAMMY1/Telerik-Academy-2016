using System;
using System.Collections.Generic;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.ReadLine();

        string numbersAsString = Console.ReadLine();
        int numberX = int.Parse(Console.ReadLine());

        var numbers = numbersAsString.Split(' ').Select(int.Parse);

        int appearances = countAppearances(numbers, numberX);

        Console.WriteLine(appearances);
    }

    static int countAppearances(IEnumerable<int> numbers, int numberToCount)
    {
        int count = 0;

        foreach (var number in numbers)
        {
            if (number == numberToCount)
            {
                count++;
            }
        }

        return count;
    }
}

