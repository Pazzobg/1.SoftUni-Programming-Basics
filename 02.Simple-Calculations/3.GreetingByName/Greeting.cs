﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GreetingByName
{
    class Greeting
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
