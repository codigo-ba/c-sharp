/*Ejercicio 2 — Calculadora básica: Solicitar dos enteros y mostrar suma, resta, multiplicación y división
 con resultado decimal. Controlar división por cero.*/
 using System;
class Program
{
 static void Main()
 {
    Console.Write("Ingresá el primer número entero: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Ingresá el segundo número entero: ");
    int num2 = int.Parse(Console.ReadLine());
    int suma = num1 + num2;
    int resta = num1 - num2;
    int multiplicacion = num1 * num2;
    Console.WriteLine($"\nSuma: {suma}");
    Console.WriteLine($"Resta: {resta}");
    Console.WriteLine($"Multiplicación: {multiplicacion}");
    if (num2 != 0)
    {
        double division = (double)num1 / num2;
        Console.WriteLine($"División: {division:F2}");
    }
    else
    {
        Console.WriteLine("División: no es posible dividir por cero.");
    }
 }
}
