using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrucciónFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            num1 = 0;
            int num2;
            num2 = 0;

            Console.Write("Ingrese un número para definir la Tabla de Sumar:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Has elegido la Suma de la Tabla siguiente: " + num1);

            for (int a = 0;  a <= 12; a++) 
            {
                
                Console.WriteLine( num1 +" + " + a + " = " +  (num1 + a));
            }
            Console.ReadKey();


            Console.Write("Ingrese un número para definir la Tabla de Multiplicar:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Has elegido la Suma de la Tabla siguiente: " + num2);

            for (int b = 0; b <= 12; b++)
            {

                Console.WriteLine(num1 + " - " + b + " = " + (num1 * b));
            }
            Console.ReadKey();
        }
    }
}
