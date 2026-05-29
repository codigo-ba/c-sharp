//Ejercicio 11 — Tabla personalizada: Solicitar un número y mostrar su tabla de multiplicar.
using System;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PEDIR NUMERO
            Console.Write("Ingrese un número: ");

            int numero = int.Parse(Console.ReadLine());

            // RECORRER DEL 1 AL 10
            for (int i = 1; i <= 10; i++)
            {
                // CALCULAR RESULTADO
                int resultado = numero * i;

                // MOSTRAR OPERACION
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            Console.ReadKey();
        }
    }
}

