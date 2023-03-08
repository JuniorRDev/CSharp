using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresRelacionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Operadores:
            < Menor que
            > Mayor que
            <= Menor o Igual que
            >= Mayor o Igual que
            == Igual a
            != No igual a (distinto de)
            */
            int Num1, Num2;
            bool Operaciones;

            Num1 = 10;
            Num2 = 5;
            Operaciones = (Num1 <= Num2);

            Console.WriteLine("Num1 es menor o igual que Num2? " + Operaciones);
            Console.ReadKey();
        }
    }
}
