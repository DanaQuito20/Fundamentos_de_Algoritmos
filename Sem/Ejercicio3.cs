using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            string opcion;
            int numero, suma = 0;

            do
            {
                Console.Clear();

                Console.Write("Ingrese números positivos: ");
                numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numero; i++)
                    suma += i;

                Console.WriteLine($"La suma es {suma}");

                Console.Write("¿Desea continuar? (S / N): ");
                opcion = Console.ReadLine();
            } while (opcion != "N");

            Console.WriteLine("\nPrograma finalizado...");

            Console.ReadKey();
        }
    }
}
