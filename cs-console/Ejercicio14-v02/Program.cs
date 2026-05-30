/* Ejercicio 14-v02 — Acumulador de ventas: Registrar ventas de 7 días y mostrar estadísticas.
    Estadísticas:
            Total de Ventas,
            Promedio vendido,
            Mayor venta.
            MENOR venta */

using System;

namespace Ejercicio14v02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ACUMULADOR DE VENTAS
            decimal totalVentas = 0;

            // VARIABLE PARA GUARDAR LA MAYOR VENTA
            decimal mayorVenta = 0;

            // VARIABLE PARA GUARDAR LA MENOR VENTA
            decimal menorVenta = 0;


            // REPETIR 7 VECES
            for (int i = 1; i <= 7; i++)
            {
                Console.Write($"Ingrese la venta del día {i}: ");

                decimal venta = decimal.Parse(Console.ReadLine());

                // ACUMULAR TOTAL
                totalVentas += venta;

                // PRIMERA VUELTA: SIEMPRE VA A PASAR X 'i = 1' Y  A ACTUALIZAR EL VALOR DE mayorVenta y menorVenta
                if ( i == 1)
                {
                    mayorVenta = venta;
                    menorVenta = venta;
                }
                // RESTO DE LAS VUELTAS
                else
                {
                    // VERIFICAR MAYOR VENTA
                    if (venta > mayorVenta)
                    {
                        mayorVenta = venta;
                    }
                    // VERIFICAR MENOR VENTA
                    if (venta < menorVenta)
                    {
                        menorVenta = venta;
                    }
                }
                
            }

            // CALCULAR PROMEDIO
            decimal promedio = totalVentas / 7;

            // MOSTRAR RESULTADOS
            Console.WriteLine($"Total vendido: ${totalVentas}");

            Console.WriteLine($"Promedio diario: ${promedio}");

            Console.WriteLine($"Mayor venta: ${mayorVenta}");

            Console.WriteLine($"Menor venta: ${menorVenta}");

            Console.ReadKey();
        }
    }
}

