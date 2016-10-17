using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstCharArray = Console.ReadLine();
        string secondCharArray = Console.ReadLine();

        bool areEquale = true;

        for (int i = 0; i < firstCharArray.Length; i++)
        {
            if (firstCharArray[i] < secondCharArray[i])
            {
                Console.WriteLine("<");
                areEquale = false;
                break;
            }
            else if (firstCharArray[i] > secondCharArray[i])
            {
               Console.WriteLine(">");
                areEquale = false;
                break;
            }
        }

        if (areEquale)
        {
            Console.WriteLine("=");
        }
    }
}
