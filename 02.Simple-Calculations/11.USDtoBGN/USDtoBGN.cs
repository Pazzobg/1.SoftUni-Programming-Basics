﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;

            Console.WriteLine(Math.Round(bgn, 2) + " BGN");
        }
    }
}
