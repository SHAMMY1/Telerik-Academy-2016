using System;

class MalkoKote
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        char symbol = Console.ReadLine()[0];

        int firstNumber = (((size - 2) / 4) - 1);

        Console.WriteLine(" {0}{1}{0}",symbol, new string(' ', firstNumber));

        for (int i = 0; i < firstNumber; i++)
        {
            Console.WriteLine(" {0}", new string(symbol, firstNumber + 2));
        }

        for (int i = 0; i < firstNumber; i++)
        {
            Console.WriteLine("  {0}", new string(symbol, firstNumber));
        }

        for (int i = 0; i < firstNumber; i++)
        {
            Console.WriteLine(" {0}", new string(symbol, firstNumber + 2));
        }

        Console.WriteLine(" {0}   {1}", new string(symbol, firstNumber + 2), new string(symbol, firstNumber + 1));

        for (int i = 0; i < firstNumber + 2; i++)
        {
            Console.WriteLine("{0}  {1}", new string(symbol, firstNumber + 4), symbol);
        }

        Console.WriteLine("{0} {1}", new string(symbol, firstNumber + 4), new string(symbol, 2));

        Console.WriteLine(" {0}", new string(symbol, firstNumber + 5));
    }
}

