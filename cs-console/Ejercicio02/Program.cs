using System;
using System.Collections.Generic;

namespace SistemaPedidos
{
    // 1. CLASE PRODUCTO
    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Producto(string codigo, string descripcion, decimal precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
        }

        public void MostrarInfo() => 
            Console.WriteLine($"[{Codigo}] {Descripcion} - ${Precio}");
    }

    // 2. CLASE PEDIDO (Contiene una List<Producto> en su interior)
    public class Pedido
    {
        public int Numero { get; private set; }
        // La lista de productos vive dentro del pedido (Composición)
        public List<Producto> Productos { get; private set; }

        public Pedido(int numero)
        {
            Numero = numero;
            Productos = new List<Producto>(); // Inicializamos la lista en el constructor
        }

        public void AgregarProducto(Producto p)
        {
            Productos.Add(p);
        }

        public void EliminarProducto(string codigo)
        {
            Producto productoAEncontrar = null;

            foreach (Producto p in Productos)
            {
                if (p.Codigo == codigo)
                {
                    productoAEncontrar = p;
                    break;
                }
            }

            if (productoAEncontrar != null)
            {
                Productos.Remove(productoAEncontrar);
                Console.WriteLine("¡Producto eliminado del pedido con éxito!");
            }
            else
            {
                Console.WriteLine("❌ No se encontró ningún producto con ese código en este pedido.");
            }
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (Producto p in Productos)
            {
                total += p.Precio; // Acumulamos el precio de cada producto
            }
            return total;
        }

        public void MostrarDetalle()
        {
            Console.WriteLine($"=== DETALLE DEL PEDIDO N° {Numero} ===");
            if (Productos.Count == 0)
            {
                Console.WriteLine("El pedido está vacío.");
            }
            else
            {
                foreach (Producto p in Productos)
                {
                    p.MostrarInfo();
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"TOTAL A PAGAR: ${CalcularTotal()}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número del nuevo pedido: ");
            int numeroPedido = int.Parse(Console.ReadLine());

            // Creamos la instancia del pedido principal
            Pedido miPedido = new Pedido(numeroPedido);
            string opcion = "";

            while (opcion != "5")
            {
                Console.Clear();
                Console.WriteLine($"=== GESTIÓN DE PEDIDO N° {miPedido.Numero} ===");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Calcular total");
                Console.WriteLine("4. Mostrar detalle completo");
                Console.WriteLine("5. Salir");
                Console.Write("\nElija una opción: ");

                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese código del producto: ");
                        string codigo = Console.ReadLine();
                        Console.Write("Ingrese descripción: ");
                        string desc = Console.ReadLine();
                        Console.Write("Ingrese precio: ");
                        // Uso estricto de decimal.Parse() tal como exige la cátedra
                        decimal precio = decimal.Parse(Console.ReadLine());

                        Producto nuevoProducto = new Producto(codigo, desc, precio);
                        miPedido.AgregarProducto(nuevoProducto);
                        Console.WriteLine("¡Producto agregado al pedido!");
                        break;

                    case "2":
                        Console.Write("Ingrese el código del producto a eliminar: ");
                        string codEliminar = Console.ReadLine();
                        miPedido.EliminarProducto(codEliminar);
                        break;

                    case "3":
                        Console.WriteLine($"💰 El monto total actual es: ${miPedido.CalcularTotal()}");
                        break;

                    case "4":
                        miPedido.MostrarDetalle();
                        break;

                    case "5":
                        Console.WriteLine("Saliendo del sistema de pedidos...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                if (opcion != "5")
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}