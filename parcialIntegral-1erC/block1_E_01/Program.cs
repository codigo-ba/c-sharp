/*Ejercicio 1 — Presentación personal
Solicitar nombre, apellido y edad. Mostrar una presentación con Console.WriteLine(). Utilizar Console.ReadLine(),
variables de tipos adecuados y conversión numérica.*/
using System;
class Program
{
 static void Main()
 {
 Console.Write("Ingresá tu nombre: ");
 string nombre = Console.ReadLine();
 Console.Write("Ingresá tu apellido: ");
 string apellido = Console.ReadLine();
 Console.Write("Ingresá tu edad: ");
 int edad = int.Parse(Console.ReadLine());
 Console.WriteLine($"\nHola, mi nombre es {nombre} {apellido} y tengo {edad} años.");
 }
}
