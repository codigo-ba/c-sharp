// Ejercicio 13 — Conteo de pares: Solicitar 10 números e informar cuántos son pares.
using System;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIALIZAMOS CONTADOR
            int contadorPares = 0;

            Console.WriteLine("Vas a ingresar 10 números enteros y vamos a contar cuántos son PARES");
            //REPETIMOS 10 VECES EL PEDIDO Y LA VALIDACIÓN DE N° PAR
            for(int i = 1; i <= 10; i++)
            {
                Console.Write($"Ingresá el {i}° número: ");
                int num = int.Parse(Console.ReadLine());

                if(num % 2 == 0)
                {
                    //ACTUALIZAMOS CONTADOR
                    contadorPares += 1;
                }
            }
            Console.WriteLine("======/////////////////======");
            Console.WriteLine($"Ingresaste {contadorPares} números pares.");
            Console.ReadKey();
        }
    }
}
