/*Ejercicio 4 — Cálculo de una compra
Solicitar nombre del producto, precio unitario y cantidad. Mostrar subtotal,
descuento del 10% si supera $100.000 e importe final.*/

using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingresá el nombre del producto: ");
        string producto = Console.ReadLine();
        Console.Write("Ingresá el precio unitario: ");
        decimal precioUnitario = decimal.Parse(Console.ReadLine());
        Console.Write("Ingresá la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());
        decimal subtotal = precioUnitario * cantidad;
        decimal descuento = 0m;
        if (subtotal > 100000m)
        {
            descuento = subtotal * 0.10m;
        }
        decimal importeFinal = subtotal - descuento;
        Console.WriteLine($"\nProducto: {producto}");
        Console.WriteLine($"Subtotal: ${subtotal:F2}");
        Console.WriteLine($"Descuento (10%): ${descuento:F2}");
        Console.WriteLine($"Importe final: ${importeFinal:F2}");
    }
}
