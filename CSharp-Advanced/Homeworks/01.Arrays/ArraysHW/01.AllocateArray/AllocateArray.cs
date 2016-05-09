using System;

class AllocateArray
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());

        int[] allocatedArray = new int[arrayLength];

        for (int i = 0; i < allocatedArray.Length; i++)
        {
            allocatedArray[i] = i * 5;
        }

        Console.WriteLine(string.Join("\n", allocatedArray));
    }
}

