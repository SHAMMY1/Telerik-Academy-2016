using System;
class PointInACircle
{
    static void Main(string[] args)
    {
        double coordinateX = double.Parse(Console.ReadLine());
        double coordinateY = double.Parse(Console.ReadLine());

        double diameter = 2;

        double distance = Math.Sqrt((Math.Pow(coordinateX, 2) + Math.Pow(coordinateY, 2)));

        bool isInCircle = distance <= diameter;

        Console.WriteLine("{0} {1:F2}", isInCircle ? "yes" : "no", distance);
    }
}
