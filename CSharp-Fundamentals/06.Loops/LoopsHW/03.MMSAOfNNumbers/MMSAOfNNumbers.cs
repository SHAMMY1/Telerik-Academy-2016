using System;

class MMSAOfNNumbers
{
    static void Main()
    {
        const string outputFormatString = "min={0:F2}\nmax={1:F2}\nsum={2:F2}\navg={3:F2}";

        int n = int.Parse(Console.ReadLine());

        double min;
        double max;
        double sum;
        double avg;

        min = max = sum = double.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());

            if (min > currentNumber)
            {
                min = currentNumber;
            }
            else if (max < currentNumber)
            {
                max = currentNumber;
            }

            sum += currentNumber;
        }

        avg = sum / n;

        Console.WriteLine(outputFormatString, min, max, sum, avg);
    }
}

