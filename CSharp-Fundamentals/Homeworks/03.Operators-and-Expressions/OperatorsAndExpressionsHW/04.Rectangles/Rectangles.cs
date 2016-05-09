using System;

class Rectangles
{
    static void Main()
    {
        double rectangleWidth = double.Parse(Console.ReadLine());
        double rectangleHeight = double.Parse(Console.ReadLine());

        double rectangleArea = rectangleHeight * rectangleWidth;
        double rectanglePerimeter = (rectangleHeight + rectangleWidth) * 2;

        Console.WriteLine("{0:F2} {1:F2}", rectangleArea, rectanglePerimeter);
    }
}
