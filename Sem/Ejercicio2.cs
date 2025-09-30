using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            int intentos = 3, secreto, numero;

            Console.WriteLine("********************************************************************");
            Console.WriteLine("*           Bienvenido al juego de... ¡Adivina el número!          *");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("*Instrucciones:                                                    *");
            Console.WriteLine("*1. Tienes 3 intentos                                              *");
            Console.WriteLine("*2. Cada falla tiene una pista                                     *");
            Console.WriteLine("********************************************************************");

            Random rnd = new Random();
            secreto = rnd.Next(1, 21);

            do
            {
                Console.Write("Ingresa el número a adivinar: ");
                numero = int.Parse(Console.ReadLine());

                if (secreto == numero)
                {
                    Console.WriteLine("¡Correcto, adivinaste el número!");
                    return;
                }
                else
                {
                    intentos--;

                    if (numero < secreto) Console.WriteLine("Pista: El número es mayor.\n");
                    else Console.WriteLine("Pista: El número es menor.\n");
                }               
            } while (intentos > 0);

            Console.WriteLine($"No lograste adivinar el número {secreto} :(");

            Console.ReadKey();
        }
    }
}
