/* Ejercicio 15-v02 — Login simple: Solicitar usuario y contraseña HASTA QUE sean correctos.
    Pedile al usuario: Usuario Y Contraseña.
    Usuario válido: "admin". Contraseña válida: "1234"
    Mostrar: "Acceso concedido", "Usuario incorrecto", "Contraseña incorrecta", "usuario y contraseña incorrectos" 
    según corresponda */
    using System;

    namespace Ejercicio15v02
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string user = "admin";
                string pass = "1234";

                while (true)
                {
                    Console.Write("Ingrese usuario: ");
                    string usuario = Console.ReadLine();
                    Console.Write("Ingrese contraseña: ");
                    string password = Console.ReadLine();
                    
                    if (usuario == user && password == pass)
                    {
                        Console.WriteLine("Acceso Concedido!!");
                        break;
                    }
                    else if (usuario != user && password == pass)
                    {
                        Console.WriteLine("XXX Usuario Incorrecto XXX");
                    }
                    else if (usuario == user && password != pass)
                    {
                        Console.WriteLine("XXX Contraseña Incorrecta XXX");
                    }
                    else
                    {
                        Console.WriteLine("XXX Usuario y Contraseña Incorrectos XXX");
                    }
                }
                
                Console.ReadKey();
            }
        }
    }
