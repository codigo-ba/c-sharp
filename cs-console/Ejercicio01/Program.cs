/* Ejercicio 1 — Presentación personal: Solicitar nombre, apellido, edad y ciudad.
    Mostrar un mensaje con los datos y la edad del próximo año.
    Ejemplo: Hola Juan Pérez. Tenés 25 años y vivís en Buenos Aires. El próximo año tendrás 26 años.*/
using System;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PEDIR NOMBRE
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            // PEDIR APELLIDO
            Console.Write("Ingrese apellido: ");
            string apellido = Console.ReadLine();

            // PEDIR EDAD
            Console.Write("Ingrese edad: ");
            int edad = int.Parse(Console.ReadLine());

            // PEDIR CIUDAD
            Console.Write("Ingrese ciudad: ");
            string ciudad = Console.ReadLine();

            // CALCULAR EDAD DEL PROXIMO AÑO
            int proximaEdad = edad + 1;

            // MOSTRAR RESULTADO
            Console.WriteLine(
                $"Hola {nombre} {apellido}. " +
                $"Tenés {edad} años y vivís en {ciudad}. " +
                $"El próximo año tendrás {proximaEdad} años."
            );

            Console.ReadKey();
        }
    }
}