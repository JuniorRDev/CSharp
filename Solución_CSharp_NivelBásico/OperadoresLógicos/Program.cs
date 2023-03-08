using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLógicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            bool Resultado, Resultado2;
            a = 10;
            b = 2;
            c = 0;
            d = 205;
            Resultado = (a == b) && /*And*/ (c > d);
            Resultado2 = (a > b) || /*Or*/ (c < d);

            Console.WriteLine("Cual es el Resultado de (a == b) && (c > d) : " + Resultado);
            Console.ReadKey();

            Console.WriteLine("Cual es el Resultado de (a == b) || (c > d) : " + Resultado2);
            Console.ReadKey();
        }
    }
}
