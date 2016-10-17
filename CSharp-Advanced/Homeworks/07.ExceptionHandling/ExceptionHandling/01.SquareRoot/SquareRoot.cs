using System;

class SquareRoot
{
    static void Main()
    {
        try
        {

            double number = double.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new Exception();
            }
            Console.WriteLine("{0:F3}", Math.Sqrt(number));
        }
        catch (Exception)
        {

            Console.WriteLine("Invalid number"); ;
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

