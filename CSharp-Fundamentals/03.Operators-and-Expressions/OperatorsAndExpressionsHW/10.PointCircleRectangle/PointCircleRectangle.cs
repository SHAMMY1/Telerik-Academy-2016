using System;

class PointCircleRectangle
{
    static void Main()
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());

        double circleX = 1;
        double circleY = 1;
        double circleDiameter = 1.5;
        double distanceFromCircleCenter = Math.Sqrt(Math.Pow(pointX - circleX, 2) + Math.Pow(pointY - circleY, 2));

        bool isInCircle = distanceFromCircleCenter <= circleDiameter;

        double rectangleTop = 1;
        double rectangleLeft = -1;
        double rectangleWidth = 6;
        double rectangleHeight= 2;
        double rectangleBotem = rectangleTop - rectangleHeight;
        double rectangleRight = rectangleLeft + rectangleWidth;

        bool isInRectangle = ((rectangleLeft <= pointX) && (pointX <= rectangleRight)) && ((rectangleBotem <= pointY) && (pointY <= rectangleTop));

        string circleMessage = isInCircle ? "in" : "out";
        string rectangleMessage = isInRectangle ? "in" : "out";

        Console.WriteLine("{0}side circle {1}side rectangle", circleMessage, rectangleMessage);
    }
}
