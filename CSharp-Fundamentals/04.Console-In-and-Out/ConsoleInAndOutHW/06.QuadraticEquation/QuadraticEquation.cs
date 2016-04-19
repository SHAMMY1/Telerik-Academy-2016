using System;


class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());


        double D = Math.Pow(b, 2) - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("{0:F2}", x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);


            Console.WriteLine("{0:F2}\n{1:F2}", x2, x1);
        }
    }
}
