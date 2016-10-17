using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class AnimalPlanet
    {
        private static int[][] map;
        private static readonly Dictionary<string, Point> directions = new Dictionary<string, Point>
        {
            { "L", new Point(0, -1) },
            { "R", new Point(0, 1) },
            { "T", new Point(-1, 0) },
            { "B", new Point(1, 0) }
        };

        static void Main()
        {
            int baseColCount = int.Parse(Console.ReadLine());
            int rowsCount = int.Parse(Console.ReadLine());
            var porcArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rabbitArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var porc = new Animale(porcArr);
            var rabbit = new Animale(rabbitArr);

            GenerateMap(rowsCount, baseColCount);

            porc.AddPoint();
            rabbit.AddPoint();

            string commandLine = Console.ReadLine();

            while (commandLine != "END")
            {
                var commandAsArray = commandLine.Split(' ');

                string animal = commandAsArray[0];
                string direction = commandAsArray[1];
                int steps = int.Parse(commandAsArray[2]);

                if (animal == "R")
                {
                    rabbit.Row = directions[direction].Row * steps;
                    rabbit.Col = directions[direction].Col * steps;
                    rabbit.AddPoint();
                }
                else
                {
                    porc.Row = directions[direction].Row * steps;
                    porc.Col = directions[direction].Col * steps;
                    porc.AddPoint();
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine("rabbit {0}", rabbit.Points);
            Console.WriteLine("porc {0}", porc.Points);
        }

        private static void GenerateMap(int rows, int baseCols)
        {
            map = new int[rows][];

            for (int i = 0; i < map.Length / 2; i++)
            {
                int currentColCount = (i + 1) * baseCols;
                map[i] = new int[currentColCount];
                map[map.Length - 1 - i] = new int[currentColCount];
            }

            for (int row = 0; row < map.Length; row++)
            {
                for (int col = 0; col < map[row].Length; col++)
                {
                    map[row][col] = (row + 1) * (col + 1);
                }
            }
        }

        private static void PrintMap()
        {
            Console.WriteLine();
            for (int row = 0; row < map.Length; row++)
            {
                for (int col = 0; col < map[row].Length; col++)
                {
                    Console.Write(map[row][col].ToString().PadRight(3));
                }
                Console.WriteLine();
            }
        }

        private class Point
        {
            public Point(int row, int col)
            {
                this.Row = row;
                this.Col = col;
            }

            public Point(int[] arr)
            {
                this.Row = arr[0];
                this.Col = arr[1];
            }

            public int Row { get; set; }
            public int Col { get; set; }

        }

        private class Animale : Point
        {
            public Animale(int row, int col)
                : base(row, col)
            { }

            public Animale(int[] arr)
                : base(arr)
            { }

            public int Points { get; set; }


            public void AddPoint()
            {
                this.Points += map[this.Row][this.Col];
                map[this.Row][this.Col] = 0;
            }
        }

    }

}
