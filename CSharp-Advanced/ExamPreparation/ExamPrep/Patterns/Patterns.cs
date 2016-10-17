using System;
using System.Linq;
using System.IO;

class Patterns
{
    static void Main()
    {StreamReader file = new StreamReader("test.022.in.txt");
        int n = int.Parse(file.ReadLine());
        long sum = long.MinValue;

        var matrix = new int[n, n];

        
        for (int i = 0; i < n; i++)
        {
            var currentRow = file.ReadLine().Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(currentRow[j]);  
            }
        }

        bool hasPat = false;

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < n - 4; j++)
            {
                if ((matrix[i, j] + 1 == matrix[i, j + 1]) &&
                    (matrix[i, j] + 2 == matrix[i, j + 2]) &&
                    (matrix[i, j] + 3 == matrix[i + 1, j + 2]) &&
                    (matrix[i, j] + 4 == matrix[i + 2, j + 2]) &&
                    (matrix[i, j] + 5 == matrix[i + 2, j + 3]) &&
                    (matrix[i, j] + 6 == matrix[i + 2, j + 4]))
                {
                    long currentSum = (matrix[i, j] * 7) + 21;

                    if (currentSum > sum)
                    {
                        sum = currentSum;
                    }

                    hasPat = true;
                }
            }
        }

        if (hasPat)
        {
            Console.WriteLine("YES " + sum);
        }
        else
        {
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine("NO " + sum);
        }
    }
}

