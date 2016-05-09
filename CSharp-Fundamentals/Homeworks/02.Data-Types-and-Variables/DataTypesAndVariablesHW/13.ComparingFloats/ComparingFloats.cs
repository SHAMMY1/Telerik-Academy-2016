using System;

class ComparingFloats
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;

        bool areEqual = Math.Abs(firstNumber - secondNumber) < eps;

        Console.WriteLine(areEqual.ToString().ToLower());
    }
}

