using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCíclicaDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Num = 0;
            
            do
            {
                Console.WriteLine("El valor de la variable Num es: " + Num);
                Num++;

            }while (Num <= 10);
            Console.ReadKey();
        }
    }
}
