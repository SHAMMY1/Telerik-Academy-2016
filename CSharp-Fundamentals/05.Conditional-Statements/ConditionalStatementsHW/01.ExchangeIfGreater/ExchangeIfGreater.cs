using System;

class ExchangeIfGreater
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            int lastAvalue = a;
            a = b;
            b = lastAvalue;
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}

