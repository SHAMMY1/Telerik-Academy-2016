using System;

class CompareArrays
{
    static void Main()
    {
        int arraysLength = int.Parse(Console.ReadLine());

        var firstArray = new int[arraysLength];
        var secondArray = new int[arraysLength];

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        string areEqual = "Equal";

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                areEqual = "Not equal";
            }
        }

        Console.WriteLine(areEqual);
    }
}

