using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, cyfra, iloczyn = 1;
            Console.WriteLine("Podaj liczbę: ");
            x = Convert.ToInt32(Console.ReadLine());


            for (; x > 0;)
            {
                cyfra = x % 10;
                x = x / 10;
                iloczyn = iloczyn * cyfra;
            }

            Console.WriteLine(iloczyn);
            Console.ReadKey();

            #region p.Tomasz
            int liczba = 2231;
            int suma = 1;
            int bufLicz = 0;
            string bufor = Convert.ToString(liczba);
            for (int i = 0; i < bufor.Length; i++)
            {
                bufLicz = Int32.Parse(Convert.ToString(bufor[i]));
                suma = bufLicz * suma;
            }
            Console.WriteLine(suma);
            Console.ReadLine();
            #endregion
        }
    }
}
