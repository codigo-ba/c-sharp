/*Ejercicio 6 — Número mayor. Solicitar tres enteros e informar el mayor. Contemplar valores iguales.*/
using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingresá el primer número entero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingresá el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Ingresá el tercer número entero: ");
        int num3 = int.Parse(Console.ReadLine());
        if (num1 == num2 && num2 == num3)
        {
        Console.WriteLine($"\nLos tres números son iguales ({num1}).");
        }
        else if (num1 >= num2 && num1 >= num3)
        {
        Console.WriteLine($"\nEl número mayor es: {num1}");
        }
        else if (num2 >= num1 && num2 >= num3)
        {
        Console.WriteLine($"\nEl número mayor es: {num2}");
        }
        else
        {
        Console.WriteLine($"\nEl número mayor es: {num3}");
        }
    }
}

