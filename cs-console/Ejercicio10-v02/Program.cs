// Ejercicio 10 — Secuencia numérica: Mostrar números del 1 al 20 y luego del 20 al 1.
//  Usar WHILE loop.
using System;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MOSTRAR DEL 1 AL 20
            int i = 1;

            while (i <= 20)
            {
                Console.Write($"{i} ");

                i++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("----------");

            // MOSTRAR DEL 20 AL 1
            i = 20;

            while (i >= 1)
            {
                Console.Write($"{i} ");

                i--;
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}

