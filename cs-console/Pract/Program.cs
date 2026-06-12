/*  Integrador: Realizar un programa que permita:
• Cargar un vector de números enteros. Cantidad según usuario.
• Mostrar el vector.
• Mostrar la cantidad de números pares ingresados.
• Mostrar el número máximo ingresado.
• Mostrar el número mínimo ingresado.(pasar por REF)
 */

using System;

namespace Pract_Integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tamaño del vector?: ");
            int tamanoVector = int.Parse(Console.ReadLine());
            int [] numeros = new int[tamanoVector];

            CargarEnteros(numeros);
            MostrarEnteros(numeros);

            int totalPares = CantidadPares(numeros);
           
            int mayor = Maximo(numeros);
            
            int menor = numeros [0];
            Minimo(numeros, ref menor);
            
            Console.WriteLine($"\nIngresaste {totalPares} números pares.");
            Console.WriteLine($"\nEl número máximo ingresado es: {mayor}");
            Console.WriteLine($"\nEl número mínimo ingresado es: {menor}");
            
            Console.ReadKey();
        }

        static void CargarEnteros(int[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese número: ");
                vector[i] = int.Parse(Console.ReadLine());
            }       
        }

        static void MostrarEnteros(int[] vector)
        {
            Console.WriteLine("\nVector Cargado: ");
            for(int i = 0; i < vector.Length; i++)
            {
               Console.Write($" {vector[i]} ");
            }
            Console.WriteLine();      
        }
        
        static int CantidadPares(int[] vector)
        {
            int contador = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] % 2 == 0)
                { contador++; }
            }
            return contador;
        }

        static int Maximo(int[] vector)
        {
            int max = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                if(vector[i] > max)
                {
                    max = vector[i];
                }
            }
            return max;
        }

        static int Minimo(int[] vector, ref int menor)
        {
            for (int i = 1; i < vector.Length; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }
            return menor;
        }
         
    }
}

