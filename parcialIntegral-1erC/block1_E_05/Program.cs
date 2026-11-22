/*Ejercicio 5 — Promedio de calificaciones. Solicitar tres notas de 0 a 10;
validar valores, calcular promedio e informar aprobado si es mayor o igual a 6.*/
using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingresá la primera nota (0 a 10): ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresá la segunda nota (0 a 10): ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.Write("Ingresá la tercera nota (0 a 10): ");
        double nota3 = double.Parse(Console.ReadLine());
        // Forma más práctica de validar: q cada nota sea válida. Si no, hacer if...else
        bool notasValidas =
        nota1 >= 0 && nota1 <= 10 &&
        nota2 >= 0 && nota2 <= 10 &&
        nota3 >= 0 && nota3 <= 10;
        if (!notasValidas)
        {
            Console.WriteLine("\nError: todas las notas deben estar comprendidas entre 0 y 10.");
        return;
        }
        double promedio = (nota1 + nota2 + nota3) / 3.0;
            Console.WriteLine($"\nPromedio: {promedio:F2}");
        if (promedio >= 6)
        {
            Console.WriteLine("Estado: Aprobado");
        }
        else
        {
            Console.WriteLine("Estado: Desaprobado");
        }
    }
}

