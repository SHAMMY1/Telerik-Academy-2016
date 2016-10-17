using System;

class Speeds
{
    static void Main()
    {
        int lenght = int.Parse(Console.ReadLine());

        int[] cars =new int[lenght];



        for (int i = 0; i < cars.Length; i++)
        {
            cars[i] = int.Parse(Console.ReadLine());
        }

        int biggestGroupLenght = 0;

        int biggestGroupSum = 0;

        int currentGroupSpeed = 0;

        int curregtGroupLenght = 0;
        int curregtGroupSum = 0;

        curregtGroupLenght++;
        biggestGroupLenght++;
        currentGroupSpeed =  cars[0];
        curregtGroupSum = biggestGroupSum =  cars[0];

        for (int i = 1; i < cars.Length; i++)
        {
            if (cars[i] > currentGroupSpeed)
            {
                curregtGroupSum += cars[i];
                curregtGroupLenght++;
            }
            else
            {
                if (curregtGroupLenght > biggestGroupLenght)
                {
                    biggestGroupLenght = curregtGroupLenght;
                    biggestGroupSum = curregtGroupSum;
                }
                else if (curregtGroupLenght == biggestGroupLenght)
                {
                    biggestGroupSum = biggestGroupSum > curregtGroupSum ? biggestGroupSum : curregtGroupSum;
                }

                curregtGroupLenght =1;
                currentGroupSpeed = cars[i];
                curregtGroupSum = cars[i];
            }
        }
        if (curregtGroupLenght > biggestGroupLenght)
        {
            biggestGroupLenght = curregtGroupLenght;
            biggestGroupSum = curregtGroupSum;
        }
        else if (curregtGroupLenght == biggestGroupLenght)
        {
            biggestGroupSum = biggestGroupSum > curregtGroupSum ? biggestGroupSum : curregtGroupSum;
        }

        Console.WriteLine(biggestGroupSum);

    }
}

