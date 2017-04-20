﻿using System;

namespace _05.SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                if (row == 0 || row == n - 1)
                    Console.Write("+");
                else
                    Console.Write("|");

                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write(" -");
                }

                if (row == 0 || row == n - 1)
                    Console.WriteLine(" +");
                else
                    Console.WriteLine(" |");

            }
        }
    }
}
