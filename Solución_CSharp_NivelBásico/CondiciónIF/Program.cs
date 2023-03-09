using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondiciónIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            double Sueldo;

            Console.Write("Ingresa tu Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingresa tu Sueldo: ");
            Sueldo = Convert.ToDouble(Console.ReadLine());
            // El Sueldo Minimo en RD si es que el sueldo es menor o igual 21000
            // Si tu Sueldo es mayor a 21000 y menor igual a 25000, tu sueldo es rentable
            // El Sueldo ingresado es mayor a 25000, tu sueldo está por encima del promedio

            if (Sueldo <= 21000)
            {
                Console.WriteLine("Hola " + Nombre + ", El sueldo que ingresaste es igual o menor al mínimo vital en RD");
                             
            }
            else if (Sueldo > 21000 && Sueldo <= 25000)
            {
                Console.WriteLine("Hola " + Nombre + ", Tu Sueldo está dentro del promedio de 21,000 a 25,000 así que es Rentable");
            }
            else if (Sueldo > 25000)
            {
                Console.WriteLine("Hola " + Nombre + ", Tu sueldo está por encima del promedio, por lo tanto eres de clase alta");
            }
                                           

            Console.ReadKey();

            if (Sueldo != 21000)
            {
                Console.WriteLine("Hola " + Nombre + ", El sueldo que ingresaste es igual o menor al mínimo vital en RD");
            }
          

        }
    }
}
