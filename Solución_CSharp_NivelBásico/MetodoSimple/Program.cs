using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoSimple
{
    internal class Program
    {
        //En los metodos todas las funciones se llaman en el main.
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
