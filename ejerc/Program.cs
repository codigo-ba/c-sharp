//Goal: Lists

using System;
using System.Collections.Generic;

namespace Ejercicio4
{
    // =========================
    // CLASE ALUMNO
    // =========================
    public class Alumno
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        // CONSTRUCTOR
        public Alumno(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // METODO
        public string Imprimir()
        {
            return $"Alumno: {Nombre} - Edad: {Edad}";
        }
    }

    // =========================
    // CLASE CURSO
    // =========================
    public class Curso
    {
        public string Nombre { get; set; }

        // LISTA DE ALUMNOS
        public List<Alumno> Alumnos { get; set; } = new List<Alumno>();

        // CONSTRUCTOR
        public Curso(string nombre)
        {
            Nombre = nombre;
        }

        // METODO
        public string Imprimir()
        {
            return $"Curso: {Nombre}";
        }
    }

    // =========================
    // MAIN
    // =========================
    internal class Program
    {
        static void Main(string[] args)
        {
            // CREAR ALUMNOS
            Alumno alumno1 = new Alumno("Ana", 30);

            Alumno alumno2 = new Alumno("Juan", 25);

            Alumno alumno3 = new Alumno("Maria", 28);

            // CREAR CURSO
            Curso curso1 = new Curso("Programación");

            // AGREGAR ALUMNOS A LA LISTA
            curso1.Alumnos.Add(alumno1);

            curso1.Alumnos.Add(alumno2);

            curso1.Alumnos.Add(alumno3);

            // MOSTRAR CURSO
            Console.WriteLine(curso1.Imprimir());

            // RECORRER LISTA DE ALUMNOS
            foreach (Alumno alumno in curso1.Alumnos)
            {
                Console.WriteLine(alumno.Imprimir());
            }

            Console.ReadKey(); //escape con ctrol + D
        }
    }
}