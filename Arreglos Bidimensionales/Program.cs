using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Bidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite número de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Digite el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,]edades = new int[filas, columnas];

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write($"Digite el elemento en la posición [{f}, {c}]: ");
                    edades[f, c] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz de edades: ");

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(edades[f, c] + "     ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}