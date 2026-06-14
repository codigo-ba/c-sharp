/*Desarrollar un programa que permita cargar un vector de números enteros, mostrarlo, informar
suma, promedio, cantidad de pares e impares, máximo, mínimo y buscar un valor*/
using System;

namespace EjercicioIntegrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del vector: ");
            int tamano = int.Parse(Console.ReadLine());
            int[] vectorEnteros = new int[tamano];

            CargarVector(vectorEnteros);
            MostrarVector(vectorEnteros);
            Console.WriteLine($"Suma: {Suma(vectorEnteros)}");
            Console.WriteLine($"Promedio: {Promedio(vectorEnteros)}");

            int p = 0;
            int ip = 0;
            CantidadParesImpares(vectorEnteros, ref p, ref ip);
            Console.WriteLine($"Pares: {p}\nImpares: {ip}");
            //Contar pares e impares por Tuplas
            (int pa, int im) = ParesImparesTupla(vectorEnteros);
            Console.WriteLine($"Pares x Tupla: {pa}\nImpares x Tupla: {im}");

            int max = vectorEnteros[0];
            int min = vectorEnteros[0];
            MaxMin(vectorEnteros, ref max, ref min);
            Console.WriteLine($"Máximo: {max}\nMínimo: {min}");

            bool valorEncontrado = BuscarValor(vectorEnteros);
            if(valorEncontrado)
            { Console.WriteLine("El número se encuentra en el vector."); }
            else
            { Console.WriteLine("No se encontró el número en el vector."); }
            Console.WriteLine();
            Console.WriteLine("----- FIN DEL EJERCICIO INTEGRADOR -----");
        }

        static void CargarVector(int[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Ingrese el {i + 1}° número: ");
                int n = int.Parse(Console.ReadLine());
                vector[i] = n;
            }
        }

        static void MostrarVector(int[] vector)
        {
            Console.WriteLine("\nVector ingresado:");
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.WriteLine();
        }

        static int Suma(int[] vector)
        {
            int sum = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                sum += vector[i];
            }
            return sum;
        }

        static double Promedio(int[] vector)
        {
            double prom = Math.Round(Suma(vector)/(double)vector.Length, 2);
            return prom;
        }
        
        static void CantidadParesImpares(int[] vector, ref int p, ref int ip)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] % 2 == 0)
                { p++; }
                else
                { ip++; }
            }
        }
        // Contar pares e impares por Tuplas
        static (int par, int impar) ParesImparesTupla(int[] vector)
        {
            int par = 0;
            int impar = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] % 2 == 0)
                { par++; }
                else
                { impar++; }
            }
            return (par, impar);
        }

        static void MaxMin(int[] vector, ref int mx, ref int mn)
        {
            for(int i = 1; i < vector.Length; i++)
            {
                if(vector[i] > mx)
                { mx = vector[i]; }

                if(vector[i] < mn)
                { mn = vector[i]; }
            }
        }

        static bool BuscarValor(int[] vector)
        {
            Console.Write("Número a buscar: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
