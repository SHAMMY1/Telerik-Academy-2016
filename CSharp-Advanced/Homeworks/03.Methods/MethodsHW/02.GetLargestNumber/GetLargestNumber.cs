using System;
using System.Linq;

class GetLargestNumber
{
    static void Main()
    {
        string numbersAsString = Console.ReadLine();

        var numbers = numbersAsString.Split(' ').Select(int.Parse).ToArray();

        double biggestNumber = GetMax(GetMax(numbers[0], numbers[1]), numbers[2]);

        Console.WriteLine(biggestNumber);
    }

    static double GetMax(double firstNumber, double secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}

