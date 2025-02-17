﻿using System;

namespace _05Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            //условие:
            //Ани обича да пътува и иска тази година да посети няколко различни
            //дестинации.Като си избере дестинация, ще прецени колко пари ще й трябват,
            //за да отиде до там и ще започне да спестява.Когато е спестила достатъчно,
            //ще може да пътува.



            //От конзолата всеки път ще се четат първо дестинацията и
            //минималния бюджет, който ще е нужен за пътуването.

            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());
                double savings = 0;

                while (savings < minBudget)
                {
                    savings += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
            //След това ще се четат няколко суми, които Ани спестява
            //като работи и когато успее да събере достатъчно за пътуването,
            //ще заминава, като на конзолата трябва да се изпише:
            //"Going to {дестинацията}!"
            //Когато е посетила всички дестинации, които иска,
            //вместо дестинация ще въведе "End" и програмата ще приключи.
        }
    }
}
