using System;

public class Producto
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int CantidadDisponible { get; private set; }

    public Producto(string codigo, string descripcion, decimal precio, int cantidadInicial)
    {
        Codigo = codigo;
        Descripcion = descripcion;

        if (precio >= 0)
        {
            Precio = precio;
        }
        else
        {
            Precio = 0;
            Console.WriteLine("Precio inválido. Se asignó 0.");
        }

        if (cantidadInicial >= 0)
        {
            CantidadDisponible = cantidadInicial;
        }
        else
        {
            CantidadDisponible = 0;
            Console.WriteLine("Cantidad inicial inválida. Se asignó 0.");
        }
    }

    public void IngresarStock(int cantidad)
    {
        if (cantidad > 0)
        {
            CantidadDisponible += cantidad;
        }
        else
        {
            Console.WriteLine("La cantidad a ingresar debe ser positiva.");
        }
    }

    public void RetirarStock(int cantidad)
    {
        if (HayStock(cantidad))
        {
            CantidadDisponible -= cantidad;
        }
        else
        {
            Console.WriteLine("No se pudo retirar stock: cantidad inválida o stock insuficiente.");
        }
    }

    public bool HayStock(int cantidad)
    {
        return cantidad > 0 && CantidadDisponible >= cantidad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Código: {Codigo} | Descripción: {Descripcion} | Precio: ${Precio} | Stock: {CantidadDisponible}");
    }
}

class Program
{
    static void Main()
    {
        int stockInicial1 = int.Parse("15");
        decimal precio1 = decimal.Parse("12500.50");

        Producto p1 = new Producto("P01", "Teclado", precio1, stockInicial1);
        Producto p2 = new Producto("P02", "Mouse", decimal.Parse("8200"), int.Parse("8"));

        p1.MostrarInformacion();
        p2.MostrarInformacion();

        Console.WriteLine("\n--- Operaciones ---");
        p1.IngresarStock(5);
        p1.RetirarStock(10);
        p1.RetirarStock(50); // No alcanza el stock

        p2.RetirarStock(3);
        p2.IngresarStock(-1); // Cantidad no positiva

        Console.WriteLine("\n--- Estado final ---");
        p1.MostrarInformacion();
        p2.MostrarInformacion();
    }
}
