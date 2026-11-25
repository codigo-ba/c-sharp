/*Ejercicio 20 — Gestión de notas
Administrar notas de 10 estudiantes con menú: cargar, listar, promedio, mayor, consultar por posición y salir.
Usar vectores y métodos, con validaciones.*/

using System;

class Program
{
    static void Main()
    {
        const int CANTIDAD_ESTUDIANTES = 10;
        double[] notas = new double[CANTIDAD_ESTUDIANTES];
        bool cargadas = false;
        int opcion;

        do
        {
            MostrarMenu();
            opcion = int.Parse(Console.ReadLine() ?? "0");

            if (opcion == 1)
            {
                CargarNotas(notas);
                cargadas = true;
            }
            else if (opcion == 2)
            {
                if (!cargadas)
                {
                    Console.WriteLine("Primero debés cargar las notas (opción 1).");
                }
                else
                {
                    ListarNotas(notas);
                }
            }
            else if (opcion == 3)
            {
                if (!cargadas)
                {
                    Console.WriteLine("Primero debés cargar las notas (opción 1).");
                }
                else
                {
                    double promedio = CalcularPromedio(notas);
                    Console.WriteLine($"Promedio general: {promedio:F2}");
                }
            }
            else if (opcion == 4)
            {
                if (!cargadas)
                {
                    Console.WriteLine("Primero debés cargar las notas (opción 1).");
                }
                else
                {
                    double mayor = ObtenerMayorNota(notas);
                    Console.WriteLine($"Nota más alta: {mayor:F2}");
                }
            }
            else if (opcion == 5)
            {
                if (!cargadas)
                {
                    Console.WriteLine("Primero debés cargar las notas (opción 1).");
                }
                else
                {
                    ConsultarPorPosicion(notas);
                }
            }
            else if (opcion == 6)
            {
                Console.WriteLine("Saliendo del sistema de gestión de notas...");
            }
            else
            {
                Console.WriteLine("Opción inválida. Elegí un número entre 1 y 6.");
            }

        } while (opcion != 6);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n--- GESTIÓN DE NOTAS (10 ESTUDIANTES) ---");
        Console.WriteLine("1. Cargar notas");
        Console.WriteLine("2. Listar notas");
        Console.WriteLine("3. Promedio");
        Console.WriteLine("4. Nota mayor");
        Console.WriteLine("5. Consultar por posición");
        Console.WriteLine("6. Salir");
        Console.Write("Elegí una opción: ");
    }

    static void CargarNotas(double[] notas)
    {
        for (int i = 0; i < notas.Length; i++)
        {
            double nota;
            do
            {
                Console.Write($"Ingresá la nota del estudiante [{i}] (0 a 10): ");
                nota = double.Parse(Console.ReadLine() ?? "-1");

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Nota inválida. Debe estar entre 0 y 10.");
                }
            } while (nota < 0 || nota > 10);

            notas[i] = nota;
        }

        Console.WriteLine("Notas cargadas correctamente.");
    }

    static void ListarNotas(double[] notas)
    {
        Console.WriteLine("\n--- Listado de notas ---");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"Posición {i}: {notas[i]:F2}");
        }
    }

    static double CalcularPromedio(double[] notas)
    {
        if (notas == null || notas.Length == 0)
        {
            return 0.0;
        }

        double suma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
        }

        return suma / notas.Length;
    }

    static double ObtenerMayorNota(double[] notas)
    {
        double mayor = notas[0];
        for (int i = 1; i < notas.Length; i++)
        {
            if (notas[i] > mayor)
            {
                mayor = notas[i];
            }
        }

        return mayor;
    }

    static void ConsultarPorPosicion(double[] notas)
    {
        Console.Write($"Ingresá la posición a consultar (0 a {notas.Length - 1}): ");
        int pos = int.Parse(Console.ReadLine() ?? "-1");

        if (pos >= 0 && pos < notas.Length)
        {
            Console.WriteLine($"Posición {pos} -> Nota: {notas[pos]:F2}");
        }
        else
        {
            Console.WriteLine($"Posición inválida. Debe estar entre 0 y {notas.Length - 1}.");
        }
    }
}
