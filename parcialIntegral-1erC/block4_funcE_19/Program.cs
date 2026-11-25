/*Ejercicio 19 — Búsqueda mediante métodos
Implementar CargarVector(), BuscarNumero() (devuelve primera posición o -1) y MostrarVector().
Invocarlos desde Main().*/
using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        CargarVector(numeros);
        MostrarVector(numeros);
        Console.Write("\nIngresá el número a buscar: ");
        int buscado = int.Parse(Console.ReadLine() ?? "0");
        int posicion = BuscarNumero(numeros, buscado);
        if (posicion != -1)
        {
            Console.WriteLine($"El número {buscado} aparece por primera vez en la posición {posicion}.");
        }
        else
        {
            Console.WriteLine($"El número {buscado} no se encuentra en el vector.");
        }
    }
    static void CargarVector(int[] vector)
    {
        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"Ingresá el elemento [{i}]: ");
            vector[i] = int.Parse(Console.ReadLine() ?? "0");
        }
    }
    static int BuscarNumero(int[] vector, int buscado)
    {
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] == buscado)
            {
                return i;
            }
        }
        return -1;
    }
    static void MostrarVector(int[] vector)
    {
        Console.WriteLine("\n--- Contenido del vector ---");
        for (int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine($"Posición {i}: {vector[i]}");
        }
    }
}
