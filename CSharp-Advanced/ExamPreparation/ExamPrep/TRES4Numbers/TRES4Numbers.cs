using System;
using System.Text;

class Program
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());

        string tresNumber = DecimalToTres(number);

        Console.WriteLine(tresNumber);
    }

    private static string DecimalToTres(ulong number)
    {
        string[] digits = { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };
        StringBuilder result = new StringBuilder();
        uint baseSystem = 9;

        do
        {
            int numberToAdd = (int)(number % baseSystem);
            result.Insert(0, digits[numberToAdd]);
            number /= baseSystem;
        } while (number > 0);

        return result.ToString();
    }
}

