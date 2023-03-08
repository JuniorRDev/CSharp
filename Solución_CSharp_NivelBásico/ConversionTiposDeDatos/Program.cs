using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionTiposDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Nombre;
            int Edad;
            bool Casado;
            double Sueldo;

            Console.Write("Ingrese su Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            //Edad = int.Parse(Console.ReadLine()); // 1era Opcion
            Edad = Convert.ToInt32(Console.ReadLine()); // 2nda Opcion

            Console.Write("Eres Casado? ");
            //Casado = bool.Parse(Console.ReadLine()); // 1era Opcion
            Casado = Convert.ToBoolean(Console.ReadLine()); // 2nda Opcion

            Console.Write("Cual es tu Sueldo? ");
            //Sueldo = double.Parse(Console.ReadLine()); // 1era Opcion
            Sueldo = Convert.ToDouble(Console.ReadLine()); // 2nda Opcion
 

            Console.ReadKey();  

        }
    }
}
