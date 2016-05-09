using System;

class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double totalSheets = n * s;

        double totalRealms = totalSheets / 400;

        double totalPrise = totalRealms * p;

        Console.WriteLine("{0:F3}", totalPrise);
    }
}

