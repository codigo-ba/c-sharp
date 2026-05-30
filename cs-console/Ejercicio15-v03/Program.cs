/* Ejercicio 15-v03 — Login simple: Solicitar usuario y contraseña HASTA QUE sean correctos.
    Pedile al usuario: Usuario Y Contraseña.
    Usuario válido: "admin". Contraseña válida: "1234"
    Mostrar: "Acceso concedido", "Usuario incorrecto", "Contraseña incorrecta", "usuario y contraseña incorrectos" 
    según corresponda. USAR FLAGS/VARIABLES BOOLEANAS */
    using System;

    namespace Ejercicio15v03
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.Write("Ingrese usuario: ");
                    string usuario = Console.ReadLine();
                    Console.Write("Ingrese contraseña: ");
                    string password = Console.ReadLine();

                    bool usuarioCorrecto = usuario == "admin";
                    bool passwordCorrecta = password == "1234";
                    
                    if (usuarioCorrecto && passwordCorrecta)
                    {
                        Console.WriteLine("Acceso Concedido!!");
                        break;
                    }
                    else if (!usuarioCorrecto && passwordCorrecta)
                    {
                        Console.WriteLine("XXX Usuario Incorrecto XXX");
                    }
                    else if (usuarioCorrecto && !passwordCorrecta)
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

