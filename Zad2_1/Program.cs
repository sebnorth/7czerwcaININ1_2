using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_1
{
    class Program
    {
        static double Stozek(double r, double h) {
            return Math.PI*r*r*h/3;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Stozek(1,3));
            Console.ReadKey();
        }
    }
}
