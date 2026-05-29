// Ejercicio 12 — Sumatoria: Solicitar 5 números y mostrar suma total.
using System;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ACUMULADOR
            int suma = 0;

            //REPETIR 5 VECES EL PEDIDO DE NÚMEROS y ACTUALICE EL ACUMULADOR
            for(int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese número {i}: ");
                int num = int.Parse(Console.ReadLine());
                suma += num;
            }

            //MOSTRAR RESULTADOS
            Console.WriteLine($"La suma total es: {suma}");
            Console.ReadKey();
        }
    }
}
