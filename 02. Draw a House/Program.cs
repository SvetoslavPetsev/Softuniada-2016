using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Draw_a_House
{
    class Program
    {
        static void PrintTop(int n)
        {
            int lines = n - 1;
            int points = n * 2 - 1;
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= points; j++)
                {
                    if (j == n - i + 1)
                    {
                        Console.Write("*");
                    }
                    else if (j == points - (n - i))
                    {
                        Console.Write("*");
                    }
                    else if (j > n - i + 1 && j < points - (n - i))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < points; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        static void PrintLIne(int n)
        {
            int points = n * 2 - 1;
            for (int i = 0; i < points; i++)
            {
                if (i == 0 || i == points - 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }

        static void PrintWall(int n)
        {
            int lines = n - 2;
            int points = n * 2 - 1;

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < points; j++)
                {
                    if (j == 0 || j == points - 1)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            PrintTop(N);
            PrintLIne(N);
            PrintWall(N);
            PrintLIne(N);
        }
    }
}
