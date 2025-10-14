using System;
using System.Collections.Generic;
using System.Linq;

namespace TP_Pedidos_Interactivo
{
    public class Cliente
    {
        public required string Nombre { get; set; }
        public required string Direccion { get; set; }

        public string Imprimir()
        {
            return $"Cliente: {Nombre}, Dirección: {Direccion}";
        }
    }

    public class Item
    {
        public required string Codigo { get; set; }
        public required string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public decimal Importe => Cantidad * Precio;

        public string Imprimir()
        {
            return $"Item: {Codigo}, {Descripcion}, Cantidad: {Cantidad}, Precio: {Precio}, Importe: {Importe}";
        }
    }

    public class Pedido
    {
        public int NroDePedido { get; set; }
        public DateTime Fecha { get; set; }
        public required Cliente Cliente { get; set; }
        public List<Item> Items { get; set; } = new();

        public decimal Total => Items.Sum(i => i.Importe);

        public string Imprimir()
        {
            string itemsTexto = string.Join("\n  - ", Items.Select(i => i.Imprimir()));
            return $"Pedido N°{NroDePedido}\nFecha: {Fecha.ToShortDateString()}\n{Cliente.Imprimir()}\nTotal: {Total}\nItems:\n  - {itemsTexto}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Pedido> pedidos = new();

            for (int p = 1; p <= 2; p++)
            {
                Console.WriteLine($"\n--- Cargando Pedido N°{p} ---");

                // Cliente
                Console.Write("Nombre del cliente: ");
                string nombre = Console.ReadLine() ?? "";
                Console.Write("Dirección del cliente: ");
                string direccion = Console.ReadLine() ?? "";

                Cliente cliente = new Cliente { Nombre = nombre, Direccion = direccion };

                // Ítems
                List<Item> items = new();
                int cantidadItems = p == 1 ? 2 : 1;

                for (int i = 1; i <= cantidadItems; i++)
                {
                    Console.WriteLine($"\nItem {i}:");
                    Console.Write("Código: ");
                    string codigo = Console.ReadLine() ?? "";
                    Console.Write("Descripción: ");
                    string descripcion = Console.ReadLine() ?? "";
                    Console.Write("Cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine() ?? "0");
                    Console.Write("Precio: ");
                    decimal precio = decimal.Parse(Console.ReadLine() ?? "0");

                    items.Add(new Item
                    {
                        Codigo = codigo,
                        Descripcion = descripcion,
                        Cantidad = cantidad,
                        Precio = precio
                    });
                }

                Pedido pedido = new Pedido
                {
                    NroDePedido = p,
                    Fecha = DateTime.Now,
                    Cliente = cliente,
                    Items = items
                };

                pedidos.Add(pedido);
            }

            // Mostrar pedidos
            Console.WriteLine("\n=== PEDIDOS CARGADOS ===\n");
            foreach (var pedido in pedidos)
            {
                Console.WriteLine(pedido.Imprimir());
                Console.WriteLine();
            }
        }
    }
}

