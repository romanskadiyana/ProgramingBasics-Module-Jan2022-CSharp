﻿using System;

namespace _06NumberinRange
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number >= -100 && number <= 100 && number != 0)
            {
                Console.WriteLine("Yes");
            }
            else 
            { 
                Console.WriteLine("No"); 
            }
            
           
        }
    }
}
