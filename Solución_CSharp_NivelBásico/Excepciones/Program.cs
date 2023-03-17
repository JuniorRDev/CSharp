using System;

namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;

            try
            {
                Console.Write("Ingresa tu Edad: ");
                edad = int.Parse(Console.ReadLine());

                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: "+ex.Message);
            }
            Console.ReadKey();
        }
    }
}
