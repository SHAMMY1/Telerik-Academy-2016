using System;
using System.Collections.Generic;

class EnterNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int start = 1;
        int end = 100;

        numbers.Add(start);
        
        try
        {
            for (int i = 0; i < 10; i++)
            {
                start = EnterNumber(start, end);

                numbers.Add(start);
            }

            numbers.Add(end);

            Console.WriteLine(string.Join(" < ", numbers));
        }
        catch (Exception e)
        {

            Console.WriteLine("Exception");
        }

    }

    private static int EnterNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= start || number >= end)
        {
            throw new Exception();
        }

        return number;
    }
}

