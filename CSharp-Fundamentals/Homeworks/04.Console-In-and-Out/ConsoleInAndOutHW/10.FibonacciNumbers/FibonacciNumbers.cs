using System;

class FibonacciNumbers
{
    static void Main()
    {
        long numberN = long.Parse(Console.ReadLine());

        long beforeLastFibonacci = 0;
        long lastFibonacci = 1;

        Console.Write(beforeLastFibonacci);

        if (numberN > 1)
        {
            Console.Write(", " + lastFibonacci);
        }

        for (int i = 2; i < numberN; i++)
        {
            long nextFibonacci = checked(beforeLastFibonacci + lastFibonacci);

            beforeLastFibonacci = lastFibonacci;

            lastFibonacci = nextFibonacci;

            Console.Write(", " + nextFibonacci);
        }
    }
}