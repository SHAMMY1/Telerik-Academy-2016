﻿using System;

class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        if (1 <= score && score <= 3)
        {
            Console.WriteLine(score * 10);
        }
        else if (4 <= score && score <= 6)
        {
            Console.WriteLine(score * 100);
        }
        else if (7<= score && score <= 9)
        {
            Console.WriteLine(score * 1000);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}

