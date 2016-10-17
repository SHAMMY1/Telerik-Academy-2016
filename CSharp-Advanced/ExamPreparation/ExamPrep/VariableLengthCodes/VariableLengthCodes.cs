using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class VariableLengthCodes
{
    static void Main()
    {
        //StreamReader file = new StreamReader("test.006.in.txt");
        string codeString = Console.ReadLine();

        int tableLines = int.Parse(Console.ReadLine());
        Dictionary<int, char> codeTable = new Dictionary<int, char>();

        for (int i = 0; i < tableLines; i++)
        {
            string currentLine = Console.ReadLine();

            char symbol = currentLine[0];

            int code = int.Parse(currentLine.Substring(1));

            codeTable.Add(code, symbol);
        }

        //var numbers = codeString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        //StringBuilder builder = new StringBuilder();

        //for (int i = 0; i < length; i++)
        //{
            
        //}

        var binaryCodeString = codeString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Select(x => Convert.ToString(x, 2).PadLeft(8,'0'))
            .Aggregate((x, y) => x + y)
            .Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Length)
            .Select(x => codeTable[x])
            .Aggregate("", (x,y) => x + y);

        Console.WriteLine(binaryCodeString);
    }
}

