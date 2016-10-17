using System;
using System.Linq;
using System.Text;

class DeCatCoding
{
    static void Main()
    {
        var catWords = Console.ReadLine().Split(' ');
        var humanWords = catWords.Select(ConvertCatToHuman);

        Console.WriteLine(string.Join(" ", humanWords));
    }

    private static string ConvertCatToHuman(string number)
    {
        return DecimalToAny(AnyToDecimal(number));
    }


    private static ulong AnyToDecimal(string number)
    {
        ulong result = 0;
        ulong baseSystem = 21;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            uint CurrentNumber = (uint)(number[i] - 'a');
            int pow = number.Length - i - 1;
            result += CurrentNumber * (ulong)Math.Pow(baseSystem, pow);
        }

        return result;
    }


    private static string DecimalToAny(ulong number)
    {
        StringBuilder result = new StringBuilder();
        uint baseSystem = 26;
        do
        {
            int numberToAdd = (int)(number % baseSystem);
            result.Insert(0, (char)('a' + numberToAdd));
            number /= baseSystem;
        } while (number > 0);

        return result.ToString();
    }

}

