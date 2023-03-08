using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = { "JUNIOR", "GERALD", "JHOANDER", "ANDREW", "ANA" };

            Console.WriteLine("La Cantidad de elementos que tiene tú vector es: " + Nombres.Length);
            Console.WriteLine();

            for (int v=0; v<Nombres.Length; v++)
            {
                Console.WriteLine("Contenido del Vector Nombres en el índice " + v + " es: " + Nombres[v]);
            }
            Console.WriteLine();
            Console.WriteLine("El Nombre del Vector en el índice 0 es: " + Nombres[0]);
            Console.ReadKey();
        }
        
    }
}
