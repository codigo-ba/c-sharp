/*Ejercicio 12 — Mayor y menor elemento
Cargar 10 enteros y determinar máximo, mínimo y primera posición de cada uno, sin Max() ni Min()*/
using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Ingresá el número {i + 1} de {numeros.Length}: ");
            numeros[i] = int.Parse(Console.ReadLine() ?? "0");
        }
        int mayor = numeros[0];
        int posMayor = 0;
        int menor = numeros[0];
        int posMenor = 0;
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                posMayor = i;
            }
            if (numeros[i] < menor)
            {
                menor = numeros[i];
                posMenor = i;
            }
        }
        Console.WriteLine($"\nMayor: {mayor} (primera posición: {posMayor})");
        Console.WriteLine($"Menor: {menor} (primera posición: {posMenor})");
    }
}
