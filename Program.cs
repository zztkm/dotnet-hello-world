﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nhello, {name}, on {date:d} at {date:t}!!!");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
