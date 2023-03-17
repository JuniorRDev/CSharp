using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Matrices
             * Es una estructura de datos que permite amanecerar un conjunto de datos del mismo tipo
               a travez de columnas y filas.
             * Primero el tipo de variable [] Nombre = new tipo de variable [filas,columnas];
             * Tener en cuenta que 3 filas y 2 columnas, empieza desde 0, ej: [3,2] seria [0,1,2/0,1] 5 espacios
             * for (int i = 0; i<Persona.GetLength(0); i++) getlength(0) y (1),
               quiere decir dime el tamaño de la dimension de la matriz  donde 0 es fila y 1 es para columna.*/

            string[,] Persona = new string[4, 2];
            Persona[0, 0] = "Victor";
            Persona[0, 1] = "Ramos";
            Persona[1, 0] = "Carlos";
            Persona[1, 1] = "Ramirez";
            Persona[2, 0] = "Ana";
            Persona[2, 1] = "Arias";
            Persona[3, 0] = "Ruben ";
            Persona[3, 1] = "Osoria";

            for (int x = 0; x < Persona.GetLength(0); x++)
            {
                Console.WriteLine("Mi nombre es : " + Persona[x, 0] + " y mi apellido: " + Persona[x, 1]);
            }
            Console.WriteLine();
            Console.WriteLine("Precione cualquier tecla para ver la Version de ChatGPT");
            Console.ReadLine();
            /*
            int x = 0;
            do
            {
                Console.WriteLine("Mi nombre es : " + Persona[x, 0] + " y mi apellido: " + Persona[x, 1]);
                x++;
            } while (x < Persona.GetLength(0));
            Console.ReadKey();*/








            // Console.WriteLine("El valor de la matriz persona [0,0] es: " + Persona[3,2]);

            //Version CHATGPT
            //Este código utiliza una matriz para almacenar información sobre el nombre y
            //el apellido de cuatro personas diferentes, y luego utiliza un bucle "for" para imprimir cada uno de ellos en la consola.
            string[,] Persona2 = {
            {"Victor", "Ramos"},
            {"Carlos", "Ramirez"},
            {"Ana", "Arias"},
            {"Ruben", "Osoria"}
            };

            for (int p = 0; p < Persona2.GetLength(0); p++)
            {
                Console.WriteLine("Mi nombre es : " + Persona2[p, 0] + " y mi apellido: " + Persona2[p, 1]);
            }

            Console.ReadKey();

        }
    }
}
