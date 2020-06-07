using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj liczbę: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] tab = new int[n];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                tab[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            foreach (int item in tab)
            {
                Console.WriteLine(item);
            }

            int ile = 0;


            foreach (int item in tab)
            {
                if (item < 0) ile++;
            }

            Console.WriteLine($"Ilość liczb ujemnych w danej tablicy wynosi: {ile}");
            Console.ReadKey();
        }
    }
}
