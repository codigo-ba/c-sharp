using System;

namespace GuiaFuncionesVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tamaño del vector?: ");
            int tamanoVector = int.Parse(Console.ReadLine());
            int[] vectorNum = new int [tamanoVector];
            CargarVector(vectorNum);

            int s = Suma(vectorNum);
            Console.WriteLine($"La suma de los elementos es: {s}");

            double p = Promedio(vectorNum);
            Console.WriteLine($"El promedio es: {p}");

            int imp = CantidadImpares(vectorNum);
            Console.WriteLine($"Cantidad de números impares: {imp}");

            int min = vectorNum[0];
            Minimo(vectorNum, ref min);
            Console.WriteLine($"El menor número es: {min}");

            bool hallarNum = BuscarNum(vectorNum);
            if(hallarNum)
            { Console.WriteLine("El número se encuentra en el vector."); }
            else
            { Console.WriteLine("No se encontró el número en el vector."); }

            Console.WriteLine($"El número aparece {ContarOcurrencias(vectorNum)} veces.");//Llamado a func dentro de Console

            int[] vectorResultante = MultiplicarVector(vectorNum);
            MostrarVector(vectorResultante);// Tmb SIN variable intermedia: MostrarVector(MultiplicarVector(vectorNum));
            
            int x = 10;
            int y = 25;
            Intercambiar(ref x, ref y);
            Console.WriteLine("Después del intercambio:");
            Console.Write($"A = {x}\nB = {y}\n");

            int minimo = 0;
            int maximo = 0;
            MinMax(vectorNum, ref minimo, ref maximo);
            Console.Write($"\nMáximo: {maximo}\nMínimo: {minimo}\n");

            InvertirVector(vectorNum);

            ReemplazoNegativos(vectorNum);

            Console.WriteLine($"Cantidad de números mayores: {MayorQue(vectorNum)}");

            SiPar(vectorNum);
            SiPar2(vectorNum);

            Console.WriteLine($"Porcentaje de números pares: {PorcentajePares(vectorNum)}%");
        }

        static void CargarVector(int [] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Ingresar {i+1}° número: ");
                int numero = int.Parse(Console.ReadLine());
                vector[i] = numero;
            }
        }
        static void MostrarVector(int[] vector)
        {
            Console.Write("Vector Resultante: ");
            for(int i=0; i < vector.Length; i++)
            { Console.Write($"{vector[i]} ");}
            Console.WriteLine();
        }
        // Ej#1: Escribir función que reciba un vector de números enteros y retorne la suma total de sus elementos.
        static int Suma(int[] vector)
        {
            int sum = 0;
            for(int i = 0 ; i < vector.Length; i++)
            {
                sum += vector[i];
            }
            return sum;
        }
        // Ej #2: Func que calcule y retorne el promedio de los elementos almacenados en un vector.
        static double Promedio(int[] vector)
        {
            int sum = Suma(vector); //reutilización de func Suma()
            return (double)sum / vector.Length;
        }
        // Ej #3: Func que retorne la cantidad de números impares contenidos en un vector.
        static int CantidadImpares(int[] vector)
        {
            int contador = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] % 2 != 0)
                { contador++; }
            }
            return contador;
        }
        // Ej #4: Func que determine y retorne el menor valor almacenado en un vector (por REF)
        static int Minimo(int[] vector, ref int min)
        {
            for(int i=1; i < vector.Length; i++)
            {
                if(vector[i] < min)
                {
                    min = vector[i];
                }
            }
            return min;
        }
        // Ej #5: Func que reciba un vector y un número entero, retornando true si el número existe en el vector
        //  y false en caso contrario. Debe mostrar el mensaje respectivo. 
        static bool BuscarNum(int[] vector)
        {
            Console.Write("¿Qué número entero estás buscando?: ");
            int numeroBuscado = int.Parse(Console.ReadLine());
            for(int i=0; i < vector.Length; i++)
            {
                if (vector[i] == numeroBuscado)
                { return true; }
            }
            return false;
        }
        // Ej #6: Func que reciba un vector y un número, devolviendo la cantidad de veces que dicho número aparece.
        static int ContarOcurrencias(int[] vector)
        {
            int contador = 0;

            Console.Write("Ingresa el número que querés contar: ");
            int num = int.Parse(Console.ReadLine());

            for(int i=0; i < vector.Length; i++)
            {
                if( vector[i] == num)
                { contador++; }
            }
            return contador;
        }
        // Ej #7: Func que reciba un vector y un número entero. La func deberá multiplicar cada elemento del vector por el valor ingresado.
        static int[] MultiplicarVector(int[] vector)
        {
            Console.Write("Ingresá número multiplicador: ");
            int n = int.Parse(Console.ReadLine());

            int[] resultado = new int[vector.Length];
            for(int i=0; i < vector.Length; i++)
            {
                resultado[i] = vector[i] * n;
            }
            return resultado;
        }
        // Ej #8: Func que intercambie el valor de dos variables enteras utilizando parámetros por referencia
        static void Intercambiar(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        // Ej # 9: Función que permita obtener simultáneamente el valor máximo y el valor mínimo de un vector utilizando parámetros por referencia
        static void MinMax(int[] vector, ref int min, ref int max)
        {
            min = vector[0];
            max = vector[0];
            for( int i = 1; i < vector.Length; i++)
            {
                if(vector[i] < min)
                { min = vector[i]; }
                
                if(vector[i] > max)
                { max = vector[i]; }
            }
        }
        // Ej #10: Función que invierta el orden de los elementos de un vector.
        static void InvertirVector (int[] vector)
        {
            Console.WriteLine("Vector invertido:");
            for(int i = vector.Length - 1; i >= 0; i--)
            {
                Console.Write($"{vector[i]} ");
            }
            Console.WriteLine();
        }
        // Ej # 11: Func que reemplace todos los números negativos de un vector por cero
        static void ReemplazoNegativos(int[] vector)
        {
            Console.Write("Vector Modificado: ");
            for(int i=0; i < vector.Length; i++)
            {
                if(vector[i] < 0)
                {
                    vector[i] = 0;
                }
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }
        // Ej #12:  Func que reciba un vector y un número entero, retornando cuántos elementos son mayores que dicho valor
        static int MayorQue(int[] vector)
        {
            int count = 0;
            Console.Write("Ingrese valor de referencia: ");
            int valor = int.Parse(Console.ReadLine());

            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] > valor)
                { count++; }
            }
            return count;
        }
        // Ej #13: Func que determine si todos los elementos de un vector son números pares
        static void SiPar(int[] vector)
        {
            bool flag = true;
            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] % 2 != 0)
                { flag = false; }
            }
            if (flag)
            { Console.WriteLine("Todos los números son pares."); }
            else{ Console.WriteLine("No todos los números son pares."); } 
        }
        // Ej #13 MAS EFICIENTE: Si encuentra 1 impar, consolea y sale de la func. No sigue recorriendo.
        static void SiPar2(int[] vector)
        {
            for( int i = 0; i < vector.Length; i++)
            {
                if(vector[i] % 2 != 0)
                {
                    Console.WriteLine("Versión 2: No todos los números son pares.");
                    return;
                }
            }
            Console.WriteLine("Versión 2: Todos los números son pares.");
        }
        //Ej #14: Func que calcule qué porcentaje de los elementos de un vector corresponde a números pares.
        static double PorcentajePares(int[] vector)
        {
            int contador = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] % 2 == 0)
                { contador++; }
            }
            return ((double)contador / vector.Length) *100;
        }
    }
}
