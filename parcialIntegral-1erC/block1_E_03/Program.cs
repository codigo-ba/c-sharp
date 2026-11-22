/*Ejercicio 3 — Conversión de temperaturas
Solicitar grados Celsius y convertir a Fahrenheit mediante F = C × 9/5 + 32. Mostrar dos decimales*/
using System;
class Program
{
 static void Main()
 {
    Console.Write("Ingresá la temperatura en grados Celsius: ");
    double celsius = double.Parse(Console.ReadLine() ?? "0");
    double fahrenheit = celsius * 9.0 / 5.0 + 32;
    Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit:F2} °F");
 }
}
