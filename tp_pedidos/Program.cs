using System;
using System.Collections.Generic;

namespace BibliotecaApp
{
    // 1. LA CLASE LIBRO
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        // Encapsulamiento: nadie de afuera puede cambiar el estado de disponibilidad libremente
        public bool Disponible { get; private set; }

        public Libro(string isbn, string titulo, string autor)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Disponible = true; // Todo libro nace disponible por defecto
        }

        // Método de negocio: intenta prestar el libro y previene préstamos duplicados
        public bool Prestar()
        {
            if (!Disponible)
            {
                return false; // Ya está prestado, no se puede volver a prestar
            }
            Disponible = false;
            return true;
        }

        // Método de negocio: devuelve el libro a la biblioteca
        public void Devolver()
        {
            Disponible = true;
        }

        public void MostrarInfo()
        {
            string estado = Disponible ? "Disponible" : "Prestado";
            Console.WriteLine($"ISBN: {ISBN} | Título: {Titulo} | Autor: {Autor} | Estado: [{estado}]");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> biblioteca = new List<Libro>();
            string opcion = "";

            while (opcion != "6")
            {
                Console.Clear();
                Console.WriteLine("=== GESTIÓN DE BIBLIOTECA ===");
                Console.WriteLine("1. Registrar nuevo libro");
                Console.WriteLine("2. Buscar libro por ISBN");
                Console.WriteLine("3. Prestar libro");
                Console.WriteLine("4. Devolver libro");
                Console.WriteLine("5. Listar libros disponibles");
                Console.WriteLine("6. Salir");
                Console.Write("\nElija una opción: ");

                opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarLibro(biblioteca);
                        break;
                    case "2":
                        BuscarLibro(biblioteca);
                        break;
                    case "3":
                        PrestarLibro(biblioteca);
                        break;
                    case "4":
                        DevolverLibro(biblioteca);
                        break;
                    case "5":
                        ListarDisponibles(biblioteca);
                        break;
                    case "6":
                        Console.WriteLine("Saliendo del sistema de biblioteca...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                if (opcion != "6")
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        // --- MÉTODOS AUXILIARES SEPARADOS ---

        // Método de búsqueda reutilizable por ISBN
        static Libro BuscarPorIsbn(List<Libro> lista, string isbnBuscado)
        {
            foreach (Libro l in lista)
            {
                if (l.ISBN == isbnBuscado)
                {
                    return l;
                }
            }
            return null;
        }

        static void RegistrarLibro(List<Libro> lista)
        {
            Console.Write("Ingrese el ISBN del libro: ");
            string isbn = Console.ReadLine();

            // Validación de duplicados por ISBN
            if (BuscarPorIsbn(lista, isbn) != null)
            {
                Console.WriteLine("❌ Error: Ya existe un libro registrado con ese ISBN.");
                return;
            }

            Console.Write("Ingrese el título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingrese el autor: ");
            string autor = Console.ReadLine();

            lista.Add(new Libro(isbn, titulo, autor));
            Console.WriteLine("¡Libro registrado con éxito!");
        }

        static void BuscarLibro(List<Libro> lista)
        {
            Console.Write("Ingrese el ISBN a buscar: ");
            string isbn = Console.ReadLine();

            Libro libro = BuscarPorIsbn(lista, isbn);

            if (libro != null)
            {
                Console.WriteLine("¡Libro encontrado!");
                libro.MostrarInfo();
            }
            else
            {
                Console.WriteLine("No se encontró ningún libro con ese ISBN.");
            }
        }

        static void PrestarLibro(List<Libro> lista)
        {
            Console.Write("Ingrese el ISBN del libro a prestar: ");
            string isbn = Console.ReadLine();

            Libro libro = BuscarPorIsbn(lista, isbn);

            if (libro != null)
            {
                // Intentamos prestar utilizando la lógica interna de la clase (impide duplicados)
                bool exito = libro.Prestar();
                if (exito)
                {
                    Console.WriteLine($"¡Préstamo exitoso! El libro '{libro.Titulo}' ha sido prestado.");
                }
                else
                {
                    Console.WriteLine("❌ Error: Este libro ya se encuentra prestado. No se permiten préstamos duplicados.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró ningún libro con ese ISBN.");
            }
        }

        static void DevolverLibro(List<Libro> lista)
        {
            Console.Write("Ingrese el ISBN del libro a devolver: ");
            string isbn = Console.ReadLine();

            Libro libro = BuscarPorIsbn(lista, isbn);

            if (libro != null)
            {
                if (libro.Disponible)
                {
                    Console.WriteLine("⚠️ Aviso: Este libro ya figuraba como disponible en la biblioteca.");
                }
                else
                {
                    libro.Devolver();
                    Console.WriteLine($"¡Devolución exitosa! El libro '{libro.Titulo}' ya está disponible nuevamente.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró ningún libro con ese ISBN.");
            }
        }

        static void ListarDisponibles(List<Libro> lista)
        {
            Console.WriteLine("--- LIBROS DISPONIBLES EN BIBLIOTECA ---");
            int contador = 0;

            foreach (Libro l in lista)
            {
                // Filtramos únicamente los que tienen Disponible en true
                if (l.Disponible)
                {
                    l.MostrarInfo();
                    contador++;
                }
            }

            if (contador == 0)
            {
                Console.WriteLine("No hay libros disponibles en este momento.");
            }
        }
    }
}