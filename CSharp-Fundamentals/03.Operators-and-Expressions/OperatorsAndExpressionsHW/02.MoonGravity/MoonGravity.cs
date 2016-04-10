using System;

class MoonGravity
{
    static void Main()
    {
        float weightOnEarth = float.Parse(Console.ReadLine());

        float weightOnMoon = weightOnEarth * 17 / 100;

        Console.WriteLine("{0:F3}",weightOnMoon);
    }
}

