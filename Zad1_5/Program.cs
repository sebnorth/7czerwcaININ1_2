﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, k;
            Console.Write("Podaj liczbę naturalną dodatnią n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę naturalną dodatnią k = ");
            k = Convert.ToInt32(Console.ReadLine());

            for (j = 1; j <= k; j++) // pierwszy wiersz gwiazdek
            {
                Console.Write("*");
            }
            Console.WriteLine("");

            for (i = 2; i <= n-1; i++)
            {
                Console.Write("*");

                for (j = 2; j <= k-1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine("");
            }

            for (j = 1; j <= k; j++) // ostatni wiersz gwiazdek
            {
                Console.Write("*");
            }

            Console.ReadKey(true);
        }
    }
}
