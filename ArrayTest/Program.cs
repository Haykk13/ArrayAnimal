using System;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] nums = new int[][,]
                {
                    new int[,] { {1}, {2} },
                    new int[,] { {1, 2} },
                    new int[,] { {1, 2, 3, 4, 5, 6, 7}, { 1, 2, 3, 4, 5, 6, 7 }, { 1, 2, 3, 4, 5, 6, 7 }, {1, 2, 3, 4, 5, 6, 7} },
                    new int[,] { {1}, {2}, {3}, {4} },
                    new int[,] { {1, 2, 3}, {3, 4, 5}, },
                };
            for (int i = 0; i < nums[0].GetLength(0); i++)
            {
                Console.SetCursorPosition(3, 7 + i);
                for (int j = 0; j < nums[0].GetLength(1); j++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(3, 6);
            for (int i = 0; i < nums[1].Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("* ");
            }

            for (int i = 0; i < nums[2].GetLength(0); i++)
            {
                Console.SetCursorPosition(7, 5 + i);
                for (int j = 0; j < nums[2].GetLength(1); j++)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < nums[3].GetLength(0); i++)
            {
                Console.SetCursorPosition(8, 9 + i);
                for (int j = 0; j < nums[3].GetLength(1); j++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < nums[3].GetLength(0); i++)
            {
                Console.SetCursorPosition(19, 9 + i);
                for (int j = 0; j < nums[3].GetLength(1); j++)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < nums[0].GetLength(0); i++)
            {
                Console.SetCursorPosition(19, 3 + i);
                for (int j = 0; j < nums[0].GetLength(1); j++)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < nums[4].GetLength(0); i++)
            {
                Console.SetCursorPosition(18, 1 + i);
                for (int j = 0; j < nums[4].GetLength(1); j++)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(24, 2);
            for (int i = 0; i < nums[1].Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("* ");
            }

            Console.ReadLine();
        }
    }
}
