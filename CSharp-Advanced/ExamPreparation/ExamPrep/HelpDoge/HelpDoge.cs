using System;
using System.Numerics;

class HelpDoge
{
    static void Main()
    {
        string[] nm = Console.ReadLine().Split(' ');
        long n = long.Parse(nm[0]);
        long m = long.Parse(nm[1]);

        nm = Console.ReadLine().Split(' ');
        long fx = long.Parse(nm[0]);
        long fy = long.Parse(nm[1]);

        long k = long.Parse(Console.ReadLine());

        BigInteger[,] matrix = new BigInteger[fx + 1, fy + 1];
        bool[,] enemies = new bool[n, m];

        for (long i = 0; i < k; i++)
        {
            nm = Console.ReadLine().Split(' ');
            long ex = long.Parse(nm[0]);
            long ey = long.Parse(nm[1]);

            enemies[ex, ey] = true;
        }
        matrix[0, 0] = 1;
        for (int i = 1; i < matrix.GetLength(1); i++)
        {
            matrix[0, i] = enemies[0, i] ? 0 : matrix[0, i - 1];
        }

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            matrix[i, 0] = enemies[i, 0] ? 0 : matrix[i - 1, 0];
        }

        for (long i = 1; i < matrix.GetLength(0); i++)
        {
            for (long j = 1; j < matrix.GetLength(1); j++)
            {
                if (enemies[i, j])
                {
                    matrix[i, j] = 0;
                }
                else
                {
                    {
                        matrix[i, j] = checked(matrix[i, j] + matrix[i - 1, j]);
                    }
                    {
                        matrix[i, j] = checked(matrix[i, j] + matrix[i, j - 1]); 
                    }
                }
            }
        }
        Console.WriteLine(matrix[fx, fy]);
    }
    //    bool[,] matrix = new bool[fx + 1, fy + 1];

    //    for (long i = 0; i < k; i++)
    //    {
    //        nm = Console.ReadLine().Split(' ');
    //        long ex = long.Parse(nm[0]);
    //        long ey = long.Parse(nm[1]);

    //        if (ex < matrix.GetLength(0) && ey < matrix.GetLength(1))
    //        {
    //                        matrix[ex, ey] = true;
    //        }

    //    }

    //   long result =  Find(matrix, 0, 0, fx, fy);
    //   Console.WriteLine(result);
    //}

    //static long Find(bool[,] matrix, long dogeX, long dogeY, long foodX, long foodY)
    //{
    //    if (dogeX == foodX && dogeY == foodY)
    //    {
    //        return 1;
    //    }
    //    if (dogeX > foodX  || dogeY > foodY)
    //    {
    //        return 0;
    //    }

    //    if (dogeX == matrix.GetLength(0) || dogeY == matrix.GetLength(1) || matrix[dogeX, dogeY])
    //    {
    //        return 0;
    //    }

    //    return Find(matrix, dogeX + 1, dogeY, foodX, foodY) + Find(matrix, dogeX, dogeY + 1, foodX, foodY);
    //}
}

