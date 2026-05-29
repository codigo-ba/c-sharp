/* Ejercicio 7 — Sistema de notas: Solicitar una nota y clasificarla.
Pedir al usuario una nota (0 a 10).
    Si la nota es mayor o igual a 6: Mostrar: "Aprobado"
    Si la nota es 10: Mostrar: "Excelente"
    Si está desaprobado: Mostrar: "Desaprobado"
    Si la nota es menor a 3: Mostrar: "Muy bajo rendimiento" */


using System;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PEDIR NOTA
            Console.Write("Ingrese una nota del 0 al 10: ");

            int nota = int.Parse(Console.ReadLine());

            // EVALUAR SI ES EXCELENTE
            if (nota == 10)
            {
                Console.WriteLine("Excelente");
            }

            // EVALUAR SI ESTA APROBADO
            else if (nota >= 6)
            {
                Console.WriteLine("Aprobado");
            }

            // EVALUAR MUY BAJO RENDIMIENTO
            else if (nota < 3)
            {
                Console.WriteLine("Muy bajo rendimiento");
            }

            // RESTO DE LOS DESAPROBADOS
            else
            {
                Console.WriteLine("Desaprobado");
            }

            Console.ReadKey();
        }
    }
}
