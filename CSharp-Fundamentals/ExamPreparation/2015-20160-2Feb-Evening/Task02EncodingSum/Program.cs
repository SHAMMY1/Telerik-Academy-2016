using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());

        int result = 0;
        char symbol;

        do
        {
            symbol = (char)Console.Read();

            if (char.IsDigit(symbol))
            {
                int multipliare = int.Parse(symbol.ToString());
                result *= multipliare;
            }
            else if (char.IsLetter(symbol))
            {
                int index = char.ToUpper(symbol) - 'A';
                result += index;
            }
            else
            {
                result %= m;
            }
        } while (symbol != '@');

        Console.WriteLine(result);
    }
}

