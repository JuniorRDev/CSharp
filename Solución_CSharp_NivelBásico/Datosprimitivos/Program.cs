using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datosprimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        { //Primitive data types and variables 

            /*int edad;
            string nombre = "Carmelo";
            double sueldo;
            bool soltero;
            edad = 21;
            sueldo = 21000; 
            soltero = true;*/

            /*
            Console.WriteLine("Mi nombre es: " + nombre);
            Console.WriteLine("Mi edad es: " + edad);
            Console.WriteLine("Mi sueldo es de: " + sueldo);
            Console.WriteLine("Estas casado? " + soltero);
            Console.ReadKey();*/


            //Variables Constants
            /*int edad;
            string nombre;
            double sueldo;
            bool soltero;

            Console.Write("Cuál es tu nombre?: ");
            nombre = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa tu sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());

            Console.Write ("Estas Soltero? ");
            soltero = Convert.ToBoolean(Console.ReadLine());

            

            Console.WriteLine("Tu nombre es " + nombre + " y tu edad es " + edad);
            Console.WriteLine("Tu sueldo es " + sueldo + " y la consulta de Soltero es: " + soltero);
            Console.ReadKey();
        }*/

            string Nombre;
            int Edad;
            const double Sueldo = 2500;//const double

            //Indicates that the type of a variable is resolved at runtime.
            dynamic Contenido;
            Contenido = "Bienvenido a mi Sitema";// int, caracter, f loat, boll

            Nombre = "Junior";
            Edad = 21;
            //Sueldo = 2500;
            //Sueldo = Sueldo + 100;

            Console.WriteLine("Mi nombre es " + Nombre + " y mi edad es "+ Edad + " y teniendo el sueldo = " + Sueldo);
            Console.WriteLine("Contenido: " + Contenido);
            Console.ReadLine();
    }
}
}
