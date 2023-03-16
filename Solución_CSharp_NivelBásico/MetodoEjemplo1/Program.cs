using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEjemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ingresoDatos();
            Console.ReadKey();
        }

        // Método ejemplo 1
        static void ingresoDatos()
        {
            string nombre;
            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: " + nombre);
        }
    }
}
