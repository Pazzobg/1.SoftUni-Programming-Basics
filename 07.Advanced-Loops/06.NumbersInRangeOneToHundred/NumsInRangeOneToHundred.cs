﻿using System;

namespace _06.NumbersInRangeOneToHundred
{
    class NumsInRangeOneToHundred
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: " + n);

        }
    }
}
