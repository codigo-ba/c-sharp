/*Ejercicio 18 — Método para promedios
Implementar static double CalcularPromedio(int[] notas). Cargar diez notas y mostrar promedio; 
contemplar vector vacío.*/
using System;
class Program
{
    static void Main()
    {
        //las notas probablemente deben incluirse en un double vector. usamos int para resumir
        int[] notas = new int[10];
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Ingresá la nota {i + 1} de {notas.Length}: ");
            notas[i] = int.Parse(Console.ReadLine() ?? "0");
        }
        if (notas.Length == 0)
        {
            Console.WriteLine("\nNo hay notas cargadas para calcular el promedio.");
        }
        else
        {
            double promedio = CalcularPromedio(notas);
            Console.WriteLine($"\nPromedio: {promedio:F2}");
        }
    }
    static double CalcularPromedio(int[] notas)
    {
        if (notas == null || notas.Length == 0)
        {
            return 0.0;
        }
        int suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }
        return (double)suma / notas.Length;
    }
}

