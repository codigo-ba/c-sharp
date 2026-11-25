/*Ejercicio 16 — Método de paridad
Implementar static bool EsPar(int numero). Solicitar un entero e informar el resultado.*/
using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingresá un número entero: ");
        int numero = int.Parse(Console.ReadLine() ?? "0");
        if (EsPar(numero))
        {
        Console.WriteLine($"El número {numero} es par.");
        }
        else
        {
        Console.WriteLine($"El número {numero} es impar.");
        }
    }
    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
}
