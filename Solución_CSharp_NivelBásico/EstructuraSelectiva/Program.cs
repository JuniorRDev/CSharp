using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraSelectiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Day;

            Console.Write("Ingrese el día en número: ");
            Day = Convert.ToInt32(Console.ReadLine());

            switch (Day)
            {
                case 1:
                    Console.WriteLine("Es Lunes");
                    break;

                case 2:
                    Console.WriteLine("Es Martes");
                    break;
                case 3:
                    Console.WriteLine("Es Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Es Jueves");
                    break;

                case 5:
                    Console.WriteLine("Es Viernes");
                    break;

                case 6:
                    Console.WriteLine("Es Sabado");
                    break;

                case 7:
                    Console.WriteLine("Es Domingo");
                    break;

                default: 
                    Console.WriteLine("El Número del día ingresado no es válido!.");
                    break;
                                    

            }

            Console.ReadKey();
        }
    }
}
