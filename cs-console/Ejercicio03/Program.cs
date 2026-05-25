/* Ejercicio 3 — Conversión de unidades: Solicitar kilómetros y convertir a metros, centímetros y milímetros.
    1 km = 1000 metros; 100000 cm; 1000000 mm */
using System;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PEDIR KILOMETROS
            Console.Write("Ingrese kilómetros: ");

            double kilometros = double.Parse(Console.ReadLine());

            // CONVERSIONES
            double metros = kilometros * 1000;

            double centimetros = kilometros * 100000;

            double milimetros = kilometros * 1000000;

            // MOSTRAR RESULTADOS
            Console.WriteLine($"Metros: {metros}");

            Console.WriteLine($"Centímetros: {centimetros}");

            Console.WriteLine($"Milímetros: {milimetros}");

            Console.ReadKey();
        }
    }
}

