using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj liczbę: ");
            n = Convert.ToInt32(Console.ReadLine());
            double wynik = (n + n * n) / 3.0;
            Console.WriteLine($"Wynik wynosi: {wynik}");
            Console.ReadKey();
        }
    }
}
