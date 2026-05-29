/* Ejercicio 9 — Calculadora de descuento: Solicitar precio y aplicar descuentos según corresponda.
    Pedile al usuario el monto de una compra. (decimal).
    Si el monto es mayor a 10000: Mostrar: "Tenés descuento"
    Si el monto es mayor a 20000: Mostrar: "Descuento del 20%"
    Si no: Mostrar: "Descuento del 10%"
    Si no: Mostrar: "No hay descuento" */

using System;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PEDIR MONTO
            Console.Write("Ingrese el monto de la compra: ");

            decimal monto = decimal.Parse(Console.ReadLine());

            // VARIABLE PARA GUARDAR EL DESCUENTO
            decimal descuento = 0;

            // EVALUAR DESCUENTO DEL 20%
            if (monto > 20000)
            {
                Console.WriteLine("Descuento del 20%");

                descuento = monto * 0.20m;
            }

            // EVALUAR DESCUENTO DEL 10%
            else if (monto > 10000)
            {
                Console.WriteLine("Tenés descuento");

                descuento = monto * 0.10m;
            }

            // SIN DESCUENTO
            else
            {
                Console.WriteLine("No hay descuento");
            }

            // MOSTRAR RESULTADOS SI HAY DESCUENTO
            if (descuento > 0)
            {
                decimal totalFinal = monto - descuento;

                Console.WriteLine($"Descuento: ${descuento}");

                Console.WriteLine($"Total final: ${totalFinal}");
            }

            Console.ReadKey();
        }
    }
}

