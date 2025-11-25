using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_15
{
    internal class Ejercicio_2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            Random rnd = new Random();

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    matriz[f, c] = rnd.Next(40, 51);
                    Console.Write(matriz[f, c] + "     ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz transpuesta");
            int[,] mTrans = new int[n, n];

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    mTrans[f, c] = matriz[c, f];
                    Console.Write(matriz[f, c] + "     ");
                }
                Console.WriteLine();
            }
        }
    }
}