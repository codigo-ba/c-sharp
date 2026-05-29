// Ejercicio 10 — Secuencia numérica: Mostrar números del 1 al 20 y luego del 20 al 1.

using System;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MOSTRAR DEL 1 AL 20
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("----------");

            // MOSTRAR DEL 20 AL 1
            for (int i = 20; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}


