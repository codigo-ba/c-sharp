/*Ejercicio 17 — Calculadora modularizada
Rehacer la calculadora con métodos separados para sumar, restar, multiplicar y dividir.
Main() coordina entrada y salida.*/
using System;
class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- CALCULADORA MODULARIZADA ---");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.Write("Elegí una opción (1-5): ");

            opcion = int.Parse(Console.ReadLine() ?? "0");
            if (opcion >= 1 && opcion <= 4)
            {
                Console.Write("Ingresá el primer número: ");
                double a = double.Parse(Console.ReadLine() ?? "0");
                Console.Write("Ingresá el segundo número: ");
                double b = double.Parse(Console.ReadLine() ?? "0");
                if (opcion == 1)
                {
                Console.WriteLine($"Resultado: {Sumar(a, b):F2}");
                }
                else if (opcion == 2)
                {
                Console.WriteLine($"Resultado: {Restar(a, b):F2}");
                }
                else if (opcion == 3)
                {
                Console.WriteLine($"Resultado: {Multiplicar(a, b):F2}");
                }
                else
                {
                if (b != 0)
                {
                Console.WriteLine($"Resultado: {Dividir(a, b):F2}");
                }
                else
                {
                Console.WriteLine("Error: no se puede dividir por cero.");
                }
                }
            }
            else if (opcion == 5)
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Opción inválida. Ingresá un número entre 1 y 5.");
            }
        } while (opcion != 5);
    }
    static double Sumar(double a, double b)
    {
        return a + b;
    }
    static double Restar(double a, double b)
    {
        return a - b;
    }
    static double Multiplicar(double a, double b)
    {
        return a * b;
    }
    static double Dividir(double a, double b)
    {
        return a / b;
    }
}

