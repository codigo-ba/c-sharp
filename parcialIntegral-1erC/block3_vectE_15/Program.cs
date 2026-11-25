/*Ejercicio 15 — Inventario de productos
Usar tres vectores paralelos de cinco posiciones para códigos, precios y cantidades.
Buscar por código y mostrar valor de stock del producto y total del inventario.*/
using System;
class Program
{
    static void Main()
    {
        const int TAM = 5;
        string[] codigos = new string[TAM];
        decimal[] precios = new decimal[TAM];
        int[] cantidades = new int[TAM];
        // Carga de los 5 productos en vectores paralelos
        for (int i = 0; i < TAM; i++)
        {
            Console.WriteLine($"\n--- Producto {i + 1} de {TAM} ---");
            Console.Write("Código: ");
            codigos[i] = Console.ReadLine() ?? "";
            Console.Write("Precio: ");
            precios[i] = decimal.Parse(Console.ReadLine() ?? "0");
            Console.Write("Cantidad: ");
            cantidades[i] = int.Parse(Console.ReadLine() ?? "0");
        }
        // Calcular el total del inventario (suma de precio * cantidad de cada posición)
        decimal totalInventario = 0m;
        for (int i = 0; i < TAM; i++)
        {
            totalInventario += precios[i] * cantidades[i];
        }
        // Buscar un producto por código
        Console.Write("\nIngresá el código del producto a buscar: ");
        string codigoBuscado = Console.ReadLine() ?? "";
        int indiceEncontrado = -1;
        for (int i = 0; i < TAM; i++)
        {
            if (codigos[i] == codigoBuscado)
            {
                indiceEncontrado = i;
                break;
            }
        }
        Console.WriteLine();
        if (indiceEncontrado != -1)
        {
            decimal valorStockProducto = precios[indiceEncontrado] * cantidades[indiceEncontrado];
            Console.WriteLine($"Producto encontrado: {codigos[indiceEncontrado]}");
            Console.WriteLine($"Precio unitario: ${precios[indiceEncontrado]:F2}");
            Console.WriteLine($"Cantidad: {cantidades[indiceEncontrado]}");
            Console.WriteLine($"Valor de stock del producto: ${valorStockProducto:F2}");
        }
        else
        {
            Console.WriteLine($"No se encontró ningún producto con el código '{codigoBuscado}'.");
        }
        Console.WriteLine($"Valor total del inventario: ${totalInventario:F2}");
    }
}
