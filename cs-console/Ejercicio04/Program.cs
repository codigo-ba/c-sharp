//Ejercicio 4 — Calculadora de sueldo: Solicitar nombre, horas trabajadas y valor por hora. Calcular sueldo.
using System;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PEDIR NOMBRE
            Console.Write("Ingrese nombre: ");

            string nombre = Console.ReadLine();

            // PEDIR HORAS TRABAJADAS
            Console.Write("Ingrese horas trabajadas: ");

            double horas = double.Parse(Console.ReadLine());

            // PEDIR VALOR POR HORA
            Console.Write("Ingrese valor por hora: ");

            double valorHora = double.Parse(Console.ReadLine());

            // CALCULAR SUELDO
            double sueldo = horas * valorHora;

            // MOSTRAR RESULTADO
            Console.WriteLine(
                $"Empleado: {nombre} - Sueldo: ${sueldo}"
            );

            Console.ReadKey();
        }
    }
}

