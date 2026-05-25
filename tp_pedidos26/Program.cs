// IMPORTA FUNCIONES BASICAS DEL SISTEMA, LAS LISTAS (List<>) y FUNCIONES COMO Sum()
using System;
using System.Collections.Generic;
using System.Linq;

// NAMESPACE = NOMBRE DEL PROYECTO / CONTENEDOR DE CLASES
namespace TP_Pedidos
{
     // CLASE CLIENTE
    public class ClienteModel
    {
        // CONSTRUCTOR: SE EJECUTA AUTOMATICAMENTE CUANDO HACEMOS: new ClienteModel(...)
        public ClienteModel(string nombre, string direccion)
        {
            // GUARDA EL PARAMETRO nombre EN LA PROPIEDAD Nombre
            Nombre = nombre;

            // GUARDA EL PARAMETRO direccion EN LA PROPIEDAD Direccion
            Direccion = direccion;
        }

        // PROPIEDAD Nombre
        public string Nombre { get; set; }

        // PROPIEDAD Direccion
        public string Direccion { get; set; }

        // METODO QUE DEVUELVE LOS DATOS DEL CLIENTE EN TEXTO
        public string Imprimir()
        {
            return $"Cliente: {Nombre} - Dirección: {Direccion}";
        }
    }
    // CLASE ITEM
    public class ItemModel
    {
        // CODIGO DEL ITEM
        public string Codigo { get; set; }

        // DESCRIPCION DEL ITEM
        public string Descripcion { get; set; }

        // CANTIDAD DEL ITEM
        public decimal Cantidad { get; set; }

        // PRECIO DEL ITEM
        public decimal Precio { get; set; }

        // PROPIEDAD CALCULADA
        // CALCULA AUTOMATICAMENTE:
        // Cantidad * Precio
        public decimal Importe => Cantidad * Precio;

        // METODO QUE DEVUELVE LOS DATOS DEL ITEM EN TEXTO
        public string Imprimir()
        {
            return $"{Codigo} - {Descripcion} - Cantidad: {Cantidad} - Precio: ${Precio} - Importe: ${Importe}";
        }
    }

    // =========================
    // CLASE PEDIDO
    // =========================
    public class PedidoModel
    {
        // NUMERO DEL PEDIDO
        public int NroDePedido { get; set; }

        // FECHA DEL PEDIDO
        public DateTime Fecha { get; set; }

        // CLIENTE DEL PEDIDO
        // GUARDA UN OBJETO ClienteModel
        public ClienteModel Cliente { get; set; }

        // LISTA DE ITEMS DEL PEDIDO
        // = new List<ItemModel>()
        // CREA LA LISTA VACIA
        public List<ItemModel> Items { get; set; } = new List<ItemModel>();

        // PROPIEDAD CALCULADA
        // SUMA TODOS LOS IMPORTES DE LOS ITEMS
        public decimal Total => Items.Sum(x => x.Importe);

        // METODO QUE DEVUELVE LOS DATOS DEL PEDIDO EN TEXTO
        public string Imprimir()
        {
            return $"Pedido: {NroDePedido} - Fecha: {Fecha:dd/MM/yyyy} - Cliente: {Cliente.Nombre} - Total: ${Total}";
        }
    }

    // =========================
    // CLASE PRINCIPAL
    // =========================
    internal class Program
    {
        // METODO PRINCIPAL
        // EL PROGRAMA EMPIEZA ACA
        static void Main(string[] args)
        {
            // ====================================
            // CREAR CLIENTE 1
            // ====================================

            // CREA UN OBJETO ClienteModel
            // Y EJECUTA EL CONSTRUCTOR
            ClienteModel cliente1 =
                new ClienteModel("Yamil", "Rivadavia 5600");

            // ====================================
            // CREAR CLIENTE 2
            // ====================================

            ClienteModel cliente2 =
                new ClienteModel("Pepe", "Ramon L Falcon 8001");

            // ====================================
            // CREAR PEDIDO 1
            // ====================================

            // CREA UN OBJETO PedidoModel
            PedidoModel pedido1 = new PedidoModel
            {
                // ASIGNA NUMERO DE PEDIDO
                NroDePedido = 1,

                // ASIGNA FECHA ACTUAL
                Fecha = DateTime.Now,

                // ASIGNA EL CLIENTE AL PEDIDO
                Cliente = cliente1
            };

            // ====================================
            // AGREGAR ITEM 1 AL PEDIDO 1
            // ====================================

            // pedido1.Items = LISTA DE ITEMS
            // Add() = AGREGA UN ITEM A LA LISTA
            pedido1.Items.Add(
                new ItemModel
                {
                    Codigo = "A1",
                    Descripcion = "Articulo 1",
                    Cantidad = 1m,
                    Precio = 2500m
                });

            // ====================================
            // AGREGAR ITEM 2 AL PEDIDO 1
            // ====================================

            pedido1.Items.Add(
                new ItemModel
                {
                    Codigo = "B2",
                    Descripcion = "Articulo 2",
                    Cantidad = 2m,
                    Precio = 4000m
                });

            // ====================================
            // CREAR PEDIDO 2
            // ====================================

            PedidoModel pedido2 = new PedidoModel
            {
                NroDePedido = 2,
                Fecha = DateTime.Now,
                Cliente = cliente2
            };

            // ====================================
            // AGREGAR ITEM AL PEDIDO 2
            // ====================================

            pedido2.Items.Add(
                new ItemModel
                {
                    Codigo = "C3",
                    Descripcion = "Articulo 3",
                    Cantidad = 3m,
                    Precio = 5500m
                });

            // ====================================
            // MOSTRAR PEDIDO 1
            // ====================================

            Console.WriteLine("PEDIDO 1");

            // IMPRIME DATOS DEL CLIENTE
            Console.WriteLine(cliente1.Imprimir());

            // RECORRE TODOS LOS ITEMS DEL PEDIDO
            foreach (ItemModel item in pedido1.Items)
            {
                // IMPRIME CADA ITEM
                Console.WriteLine(item.Imprimir());
            }

            // IMPRIME DATOS DEL PEDIDO Y TOTAL
            Console.WriteLine(pedido1.Imprimir());

            // SALTO DE LINEA
            Console.WriteLine();

            // ====================================
            // MOSTRAR PEDIDO 2
            // ====================================

            Console.WriteLine("PEDIDO 2");

            Console.WriteLine(cliente2.Imprimir());

            foreach (ItemModel item in pedido2.Items)
            {
                Console.WriteLine(item.Imprimir());
            }

            Console.WriteLine(pedido2.Imprimir());

            // ESPERA UNA TECLA ANTES DE CERRAR
            Console.ReadKey();
        }
    }
}