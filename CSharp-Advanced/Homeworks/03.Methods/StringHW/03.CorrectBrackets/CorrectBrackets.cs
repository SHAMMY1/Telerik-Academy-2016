using System;

class CorrectBrackets
{
    static void Main()
    {
        string expresion = Console.ReadLine();

        bool isBracketsCOrrect = checkBrakets(expresion);

        Console.WriteLine(isBracketsCOrrect ? "Correct" : "Incorrect");
    }

    static bool checkBrakets(string expresion)
    {
        int brecketCount = 0;

        for (int i = 0; i < expresion.Length; i++)
        {
            if (expresion[i] == '(')
            {
                brecketCount++;
            }
            else if (expresion[i] == ')')
            {
                brecketCount--;

                if (brecketCount < 0)
                {
                    return false;
                }
            }
        }

        if (brecketCount > 0)
        {
            return false;
        }

        return true;
    }
}

