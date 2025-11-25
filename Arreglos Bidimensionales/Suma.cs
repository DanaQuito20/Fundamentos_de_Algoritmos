using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Bidimensionales
{
    internal class Suma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matriz 1:");
            Console.Write("Digite número de filas: ");
            int filas1 = int.Parse(Console.ReadLine());

            Console.Write("Digite el número de columnas: ");
            int columnas1 = int.Parse(Console.ReadLine());

            int[,] matriz1 = new int[filas1, columnas1];

            for (int f = 0; f < filas1; f++)
            {
                for (int c = 0; c < columnas1; c++)
                {
                    Console.Write($"Digite el elemento en la posición [{f}, {c}]: ");
                    matriz1[f, c] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz 2:");
            Console.Write("Digite número de filas: ");
            int filas2 = int.Parse(Console.ReadLine());

            Console.Write("Digite el número de columnas: ");
            int columnas2 = int.Parse(Console.ReadLine());


            int[,] matriz2 = new int[filas2, columnas2];

            for (int f = 0; f < filas2; f++)
            {
                for (int c = 0; c < columnas2; c++)
                {
                    Console.Write($"Digite el elemento en la posición [{f}, {c}]: ");
                    matriz2[f, c] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nSuma de la matriz 1 y la matriz 2:");
            for (int f = 0; f < filas1; f++)
            {
                for (int c = 0; c < columnas1; c++)
                {
                    Console.Write(matriz1[f, c] + matriz2[f, c] + "     ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}