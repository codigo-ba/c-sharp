/*Ejercicio 13 — Promedio de notas
Cargar 10 notas; informar promedio, aprobados (nota ≥ 6), desaprobados y nota más alta.*/
using System;
class Program
{
    static void Main()
    {
        double[] notas = new double[10];
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Ingresá la nota {i + 1} de {notas.Length}: ");
            notas[i] = double.Parse(Console.ReadLine() ?? "0");
        }
        double suma = 0;
        int aprobados = 0;
        int desaprobados = 0;
        double notaMasAlta = notas[0];
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
            if (notas[i] >= 6)
            {
                aprobados++;
            }
            else
            {
                desaprobados++;
            }
            if (notas[i] > notaMasAlta)
            {
                notaMasAlta = notas[i];
            }
        }
        double promedio = suma / notas.Length;
        Console.WriteLine($"\nPromedio: {promedio:F2}");
        Console.WriteLine($"Aprobados (nota >= 6): {aprobados}");
        Console.WriteLine($"Desaprobados: {desaprobados}");
        Console.WriteLine($"Nota más alta: {notaMasAlta:F2}");
    }
}

