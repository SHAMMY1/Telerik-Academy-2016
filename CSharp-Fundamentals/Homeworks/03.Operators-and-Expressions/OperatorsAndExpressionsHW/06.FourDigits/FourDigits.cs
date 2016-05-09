using System;

class FourDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sum = (number % 10) + ((number / 10) % 10) + ((number / 100) % 10) + ((number / 1000) % 10);

        int reversNuber = ((number % 10) * 1000) + (((number / 10) % 10) * 100) + (((number / 100) % 10) * 10) + ((number / 1000) % 10);

        int lastDigitFirst = ((number % 10) * 1000) + (number / 10);

        int exchangeSecondAndThird = (number % 10) + (((number / 10) % 10) * 100) + (((number / 100) % 10) * 10) + (((number / 1000) % 10) * 1000);

        Console.WriteLine(sum);
        Console.WriteLine("{0:D4}",reversNuber);
        Console.WriteLine("{0:D4}",lastDigitFirst);
        Console.WriteLine(exchangeSecondAndThird);
    }
}

