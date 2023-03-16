using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Los parámetros en C# son variables que se declaran dentro de la definición de un método y que reciben valores externos cuando se llama al método.
            //Se especifican en la lista de parámetros del método entre paréntesis y
            //permiten que el método sea más flexible y adaptable al poder trabajar con diferentes valores en diferentes momentos.


            //DECLARAMOS VARIABLES POR SUS TIPOS
            String operacionMatematicas;
            int nOperacion;

            // Preguntamos al usuario qué operación desea realizar y qué número de tabla desea ver
            Console.Write("Que operación deseas realizar Sumar o Multiplicar? ");
            operacionMatematicas = Console.ReadLine();
            Console.Write("Que número de tabla deseas que se te muestre? ");
            nOperacion = int.Parse(Console.ReadLine());

            // Verificamos si el usuario desea sumar o multiplicar y llamamos al método correspondiente
            if (operacionMatematicas == "SUMAR")
            {
                Sumar(nOperacion);
            }
            else if (operacionMatematicas == "MULTIPLICAR")
            {
                Multiplicar(nOperacion);
            }
            else
            {
                Console.WriteLine("Operacion matematica no valida");
            }

            Console.ReadKey();
        }

        //Método de la tabla de Sumar
        static void Sumar(int Number)
        {
            // Realizamos un ciclo for para mostrar la tabla de suma del número dado por el usuario
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Number + " + " + a + " = " + (Number + a));
            }
        }

        //Metodo de la tabla de Multiplicación
        static void Multiplicar(int Number)
        {
            // Realizamos un ciclo for para mostrar la tabla de multiplicación del número dado por el usuario
            for (int a = 1; a <= 12; a++)
            {
                Console.WriteLine(Number + " X " + a + " = " + (Number * a));
            }
        }
    }
}