using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_2
{
    class Program
    {
        static double g(uint n) {
            if (n == 0) return -2;
            else
                return (g(n-1) + 3) / 2;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(g(1));
            Console.ReadKey();
        }
    }
}
