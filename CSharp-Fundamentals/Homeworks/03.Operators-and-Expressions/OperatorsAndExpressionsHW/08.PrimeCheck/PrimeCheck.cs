using System;

class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (number < 0)
        {
            isPrime = false;
        }
        else
        {
            int numberSqrt = (int)Math.Sqrt(number);

            for (int i = 2; i <= numberSqrt; i++)
            {
                if ((number % i) == 0)
                {
                    isPrime = false;
                }
            }
        }

        Console.WriteLine(isPrime.ToString().ToLower());
    }
}