/* Ejercicio 5 — Control de acceso: Solicitar edad e indicar si puede ingresar.
    18 años o más → puede ingresar
    menos de 18 → no puede ingresar */
using System;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PEDIR EDAD
            Console.Write("Ingrese edad: ");

            int edad = int.Parse(Console.ReadLine());

            // EVALUAR ACCESO
            if (edad >= 18)
            {
                Console.WriteLine("Puede ingresar");
            }
            else
            {
                Console.WriteLine("No puede ingresar");
            }

            Console.ReadKey();
        }
    }
}
