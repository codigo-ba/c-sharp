/* Ejercicio 15 — Login simple: Solicitar usuario y contraseña HASTA QUE sean correctos.
    Pedile al usuario: Usuario Y Contraseña.
    Usuario válido: "admin". Contraseña válida: "1234"
    Mostrar: "Acceso concedido", "Usuario incorrecto", "Contraseña incorrecta" según corresponda */

using System;
namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese usuario: ");
                string usuario = Console.ReadLine();
                Console.Write("Ingrese Contraseña: ");
                string password = Console.ReadLine();

                if (usuario != "admin")
                {
                    Console.WriteLine("Usuario incorrecto");
                }
                else if (password != "1234")
                {
                    Console.WriteLine("Constraseña Incorrecta");
                }
                else
                {
                    Console.WriteLine("Acceso Concedido");
                    break;
                }
            } 
            Console.ReadKey();
        }
    }
}
