using System;
using System.Collections.Generic;
using System.Linq;

namespace TP_Pedidos
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
            // Crear clientes
            Cliente cliente1 = new Cliente { Nombre = "Juan Pérez", Direccion = "Calle Falsa 123" };
            Cliente cliente2 = new Cliente { Nombre = "Ana Gómez", Direccion = "Av. Siempre Viva 742" };

            // Crear ítems
            Item item1 = new Item { Codigo = "A1", Descripcion = "Lapicera", Cantidad = 2, Precio = 50 };
            Item item2 = new Item { Codigo = "B2", Descripcion = "Cuaderno", Cantidad = 1, Precio = 100 };
            Item item3 = new Item { Codigo = "C3", Descripcion = "Mochila", Cantidad = 1, Precio = 500 };

            // Crear pedidos
            Pedido pedido1 = new Pedido
            {
                NroDePedido = 1,
                Fecha = DateTime.Now,
                Cliente = cliente1,
                Items = new List<Item> { item1, item2 }
            };

            Pedido pedido2 = new Pedido
            {
                NroDePedido = 2,
                Fecha = DateTime.Now,
                Cliente = cliente2,
                Items = new List<Item> { item3 }
            };

            // Imprimir pedidos
            Console.WriteLine(pedido1.Imprimir());
            Console.WriteLine();
            Console.WriteLine(pedido2.Imprimir());
        }
    }
}
