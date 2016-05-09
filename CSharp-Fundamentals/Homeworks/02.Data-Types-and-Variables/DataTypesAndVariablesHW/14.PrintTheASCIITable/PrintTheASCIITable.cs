using System;

class PrintTheASCIITable
{
    static void Main()
    {
        int startChar = 33;
        int endChar = 126;

        for (int i = startChar; i <=endChar; i++)
        {
            Console.Write((char)i);
        }
    }
}

