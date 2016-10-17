using System;

class MaximalSequence
{
    static void Main()
    {
        int arrayLength = int.Parse(Console.ReadLine());
        var numbers = new int[arrayLength];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxSequense = 0;
        int currentSequense = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                currentSequense++;
            }
            else
            {
                if (currentSequense > maxSequense)
                {
                    maxSequense = currentSequense;
                }

                currentSequense = 1;
            }
        }
        if (currentSequense > maxSequense)
        {
            maxSequense = currentSequense;
        }
      
        Console.WriteLine(maxSequense);
    }
}

