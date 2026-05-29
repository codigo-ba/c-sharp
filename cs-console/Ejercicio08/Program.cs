//Ejercicio 8 — El mayor de tres: Solicitar tres números y mostrar el mayor.
namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PEDIR PRIMER NUMERO
            Console.Write("Ingrese el primer número: ");

            int numero1 = int.Parse(Console.ReadLine());

            // PEDIR SEGUNDO NUMERO
            Console.Write("Ingrese el segundo número: ");

            int numero2 = int.Parse(Console.ReadLine());

            // PEDIR TERCER NUMERO
            Console.Write("Ingrese el tercer número: ");

            int numero3 = int.Parse(Console.ReadLine());

            // EVALUAR SI EL PRIMERO ES EL MAYOR
            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine($"El mayor es: {numero1}");
            }

            // EVALUAR SI EL SEGUNDO ES EL MAYOR
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine($"El mayor es: {numero2}");
            }

            // SI NO, EL TERCERO ES EL MAYOR
            else
            {
                Console.WriteLine($"El mayor es: {numero3}");
            }

            Console.ReadKey();
        }
    }
}


