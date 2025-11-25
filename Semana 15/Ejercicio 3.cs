using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_15
{
    internal class Ejercicio_3
    {
        static void Main(string[] args)
        {
            Console.Write("Digite número de filas: ");
            int f1 = int.Parse(Console.ReadLine());

            Console.Write("Digite el número de columnas: ");
            int c1 = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f1, c1];
            Random rnd = new Random();

            int[] suma = new int[c1];

            for (int f = 0; f < f1; f++)
            {
                for (int c = 0; c < c1; c++)
                {
                    matriz[f, c] = rnd.Next(20, 31);
                    suma[c] += matriz[f, c];
                    Console.Write(matriz[f, c] + "     ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSuma de columnas");

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int c = 0; c < c1; c++)
            {
                Console.Write(suma[c] + "     ");
            }
        }
    }
}