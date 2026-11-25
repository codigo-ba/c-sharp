/*Ejercicio 11 — Carga y visualización
Cargar 10 enteros en un vector; mostrarlos en orden de carga y en orden inverso*/
using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        // Carga de 10 enteros
        for (int i = 0; i < numeros.Length; i++)
        {
        Console.Write($"Ingresá el número {i + 1} de {numeros.Length}: ");
        numeros[i] = int.Parse(Console.ReadLine() ?? "0");
        }
        // Mostrar en orden de carga
        Console.WriteLine("\n--- Orden de carga ---");
        for (int i = 0; i < numeros.Length; i++)
        {
        Console.WriteLine($"Posición {i}: {numeros[i]}");
        }
        // Mostrar en orden inverso
        Console.WriteLine("\n--- Orden inverso ---");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
        Console.WriteLine($"Posición {i}: {numeros[i]}");
        }
    }
}

