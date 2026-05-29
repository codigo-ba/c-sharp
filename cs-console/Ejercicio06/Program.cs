//Ejercicio 6 — Número especial: Solicitar un número e indicar si es positivo, negativo o cero. (asumir decimales)

using System;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PEDIR NÚMERO
            Console.Write("Ingrese un número: ");
            double numero = double.Parse(Console.ReadLine());

            //EVALUAR SI ES POSITIVO
            if (numero > 0)
            {
                Console.WriteLine($"El número {numero} es POSITIVO");
            }
            //EVALUAR SI ES NEGATIVO
            else if (numero < 0)
            {
                Console.WriteLine($"El número {numero} es NEGATIVO");
            }
            // SI NO ES > O < A "0", ENTONCES DEBE SER 0
            else 
            {
                Console.WriteLine("El número ingresado es 0");
            }
            Console.ReadKey();
        }
    }
}
