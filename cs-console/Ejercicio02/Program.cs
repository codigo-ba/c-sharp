// Ejercicio 2.1 — Operaciones básicas: Solicitar dos números y mostrar suma, resta, multiplicación, división y resto.
// Hacer los cambios necesarios para proder operar con decimales simples
using System;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PEDIR PRIMER NUMERO
            Console.Write("Ingrese primer número: ");
            double numero1 = double.Parse(Console.ReadLine());

            // PEDIR SEGUNDO NUMERO
            Console.Write("Ingrese segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            // OPERACIONES
            double suma = numero1 + numero2;

            double resta = numero1 - numero2;

            double multiplicacion = numero1 * numero2;

            double division = numero1 / numero2;

            double resto = numero1 % numero2;

            // MOSTRAR RESULTADOS
            Console.WriteLine($"Suma: {suma}");

            Console.WriteLine($"Resta: {resta}");

            Console.WriteLine($"Multiplicación: {multiplicacion}");

            Console.WriteLine($"División: {division}");

            Console.WriteLine($"Resto: {resto}");

            Console.ReadKey();
        }
    }
}
