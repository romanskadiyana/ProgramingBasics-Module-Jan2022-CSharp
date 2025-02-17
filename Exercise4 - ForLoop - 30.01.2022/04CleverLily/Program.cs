﻿using System;

namespace _04CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            //вход:
            //Възрастта на Лили - цяло число в интервала [1...77]
            //Цената на пералнята - число в интервала[1.00...10 000.00]
            //Единична цена на играчка -цяло число в интервала[0...40]
            int age = int.Parse(Console.ReadLine());
            double priceMach = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());


            //условие:
            //Лили вече е на N години. За всеки свой рожден ден тя получава подарък. 
            //За нечетните рождени дни(1, 3, 5...n) получава играчки.
            //За четните рождени дни(2, 4, 6...n) получава пари. 
            //За втория рожден ден получава 10.00 лв, като сумата се увеличава с 10.00 лв.
            //за всеки следващ четен рожден ден(2-> 10, 4-> 20, 6-> 30...и т.н.).
            //През годините Лили тайно е спестявала парите.
            //Братът на Лили, в годините, които тя получава пари, взима по 1.00 лев от тях.
            //Лили продала играчките получени през годините,
            //всяка за P лева и добавила сумата към спестените пари.
            //С парите искала да си купи пералня за X лева. Напишете програма,
            //която да пресмята, колко пари е събрала и дали ѝ стигат да си купи пералня.


            //когато i % 2 != 0 -нечетно => играчка на стойност priceToy 


            //когато i % 2 == 0 - четно => 2-10лв, 4-20лв., 6-30лв., 8-40лв., 10/2 = 5, 20/4 =5;
            // => 2-10лв, 4-20лв., 6-30лв., 8-40лв.
            // => 10/2 = 5, 20/4 =5; -  сумата, която получава е нейната възраст  * 5;
            // => i * 5;
            // => i * 5 - 1; - Братът на Лили, в годините, които тя получава пари, взима по 1.00 лев

            double savedMoney = 0;

            for (int i = 1; i <= age; i++) //на кой рожден ден сме стигнали
            {
                if (i % 2 == 0)
                {
                    savedMoney += i * 5 - 1;
                }
                else
                {
                    savedMoney += priceToy;
                }
            }

            //изход:
            //Да се отпечата на конзолата един ред:
            //Ако парите на Лили са достатъчни:
            //"Yes! {N}" - където N е остатъка пари след покупката
            //Ако парите не са достатъчни:
            //"No! {М}" - където M е сумата, която не достига
            //Числата N и M трябва да за форматирани до вторият знак след десетичната запетая.

            if (savedMoney >= priceMach)
            {
                Console.WriteLine($"Yes! {savedMoney-priceMach:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceMach-savedMoney:f2}");
            }
        }
    }
}
