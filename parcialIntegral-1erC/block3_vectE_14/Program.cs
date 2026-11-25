/*Ejercicio 14 — Búsqueda de un elemento
Cargar 15 enteros; solicitar un valor e informar todas las posiciones en que aparece o si no existe.*/

using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[15];
        // Carga de 15 enteros
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingresá el número {i + 1} de {numeros.Length}: ");
            numeros[i] = int.Parse(Console.ReadLine() ?? "0");
        }
        Console.Write("\nIngresá el valor a buscar: ");
        int buscado = int.Parse(Console.ReadLine() ?? "0");
        bool encontrado = false;
        Console.WriteLine($"\nBuscando el valor {buscado}...");
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscado)
            {
            Console.WriteLine($"Encontrado en la posición {i}");
            encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine($"El valor {buscado} no existe en el vector.");
        }
    }
}
