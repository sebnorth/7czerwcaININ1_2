using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Podaj liczbę a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę b: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a < b) Console.WriteLine(a);

            if (a == b) Console.WriteLine("Obie liczby są równe");

            if (b < a) Console.WriteLine(b);

            Console.ReadKey();

        }
    }
}
