﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CircleAreaAndPerimeter
{
    class CircleAreaPerim
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perim = 2 * Math.PI * r;

            Console.WriteLine("Area = {0}",area);
            Console.WriteLine("Perimeter = {0}", perim);
        }
    }
}
