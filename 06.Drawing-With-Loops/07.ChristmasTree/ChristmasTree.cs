﻿using System;

namespace _07.ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");

                for(int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
