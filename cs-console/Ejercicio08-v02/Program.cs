//Ejercicio 8 — El mayor de tres: Solicitar tres números y mostrar el mayor.
//  v02: Utilizar variable intermedia.
using System;

namespace Ejercicio08v02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese primer número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());

            // ESTABLECEMOS UNA VARIABLE QUE GUARDE EL NÚMERO MAYOR.
            // LA INICIALIZAMOS CON, POR EJEMPLO, EL 1ER NÚMERO.
            int mayor = numero1;

            if (numero2 > mayor)
            {
                mayor = numero2;
            }
            if (numero3 > mayor)
            {
                mayor = numero3;
            }

            Console.WriteLine($"El mayor es: {mayor}");
            Console.ReadKey();

        }
    }
}
