using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ile;
            Console.WriteLine("Podaj liczbę: ");
            ile = Convert.ToInt32(Console.ReadLine());

            int i=1;
            int liczba = 13; 

            while (i <= ile)
            {
                if (liczba % 2 == 1) {
                    Console.WriteLine(liczba);
                    i++;
                }

                
                liczba += 13; 
            }

            Console.ReadKey();
        }
    }
}
