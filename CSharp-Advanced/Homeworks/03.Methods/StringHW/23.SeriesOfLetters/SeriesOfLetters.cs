using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string theString = Console.ReadLine();
        string result = TrimString(theString);

        Console.WriteLine(result);
    }

    static string TrimString(string str)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            result.Append(str[i]);

            while ((i + 1) < str.Length && str[i] == str[i + 1])
            {
                i++;
            }
        }

        return result.ToString();
    }
}

