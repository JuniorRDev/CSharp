using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
            //TAREA
        //SOLICITAR NOMBRE, CUANTO ME PAGAN POR DIA TRABAJADO Y LOS DIAS TRABAJADOS
        //Y EN BASE A ESO MI PROGRAMACION DEBE DECIRME CUANTO HE GANADO O DEBO COBRAR
        {
            string nombre;
            decimal pagoPorDia, salario;
            int diasTrabajados;
            // Solicitar nombre
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            // Solicitar cuánto le pagan por día trabajado
            Console.Write("Ingrese cuánto le pagan por día trabajado: ");
            pagoPorDia = decimal.Parse(Console.ReadLine());

            // Solicitar los días trabajados
            Console.Write("Ingrese los días trabajados: ");
            diasTrabajados = int.Parse(Console.ReadLine());

            // Calcular el salario
            salario = CalcularSalario(pagoPorDia, diasTrabajados);

            // Mostrar el resultado
            Console.WriteLine($"\n{nombre}, usted debe cobrar {salario:C} por {diasTrabajados} días trabajados.");
            Console.ReadKey();
        }
        //Método para obtener el total del salario osea del dinero ganado por trabajo
        static decimal CalcularSalario(decimal pagoPorDia, int diasTrabajados)
        {
            return pagoPorDia * diasTrabajados;
        }
    }
}
