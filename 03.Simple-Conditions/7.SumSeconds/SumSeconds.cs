﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var seconds = num1 + num2 + num3;
            var minutes = 0;

            if (seconds < 60)
            {
                minutes = minutes + 0;
                seconds = seconds; 
            }
            else if (seconds < 120)
            {
                minutes = minutes + 1;
                seconds = seconds - 60;
            }
            else if (seconds < 180)
            {
                minutes = minutes + 2;
                seconds = seconds - 120;
            }

            if (seconds < 10)
                Console.WriteLine(minutes + ":0" + seconds);
            else
                Console.WriteLine(minutes + ":" + seconds);
            {

            }
        }
    }
}
