using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana6_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseña, validacion;
            int intentos = 3;

            Console.WriteLine("Bienvenido al sistema de validación de contraseñas");
            Console.Write("Genere una contraseña: ");
            contraseña = Console.ReadLine();

            Console.WriteLine("\n______________________________________________________________________");
            Console.WriteLine("_                         Valide su contraseña                         _");
            Console.WriteLine("________________________________________________________________________");

            while (intentos > 0)
            {
                Console.Write("\nIngrese la contraseña: ");
                validacion = Console.ReadLine();

                if (contraseña == validacion)
                {
                    Console.WriteLine("\nAcceso conseguido. Bienvenido al sistema...");
                    return;
                }
                else
                {
                    intentos--;
                    Console.WriteLine($"Contraseña incorrecta. Intentos restantes {intentos}");
                }
            }

            Console.WriteLine("\nAcceso denegado. Cerrando programa...");
        }
    }
}
