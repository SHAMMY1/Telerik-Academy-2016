using System;

class Conductors
{
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int pLenght = Convert.ToString(p, 2).Length;


        for (int i = 0; i < m; i++)
        {
            int currentNUmber = int.Parse(Console.ReadLine());
          // Console.WriteLine(Convert.ToString(currentNUmber, 2).PadLeft(32,'0'));

            for (int k = 0; k < 31 - pLenght + 1; k++)
            {
                int startMask = 1 << k;

                bool isMach = true;

                for (int j = 0; j < pLenght; j++)
                {
                    int mask = startMask << j;
                    int currentP = p << k;

                    if (((currentNUmber & mask) == 0) != ((currentP & mask) == 0))
                    {
                        isMach = false;
                    }
                }

                if (isMach)
                {

                    for (int j = 0; j < pLenght; j++)
                    {
                        int currentMask =(~(startMask << j));


                       // Console.WriteLine(Convert.ToString(currentNUmber, 2).PadLeft(32, '0'));

                       // Console.WriteLine(Convert.ToString(currentMask, 2));
                      //  Console.WriteLine();

                        currentNUmber = currentNUmber & currentMask;
                       // k++;
                    }
                }

            }
            Console.WriteLine(currentNUmber);

        }


    }
}

