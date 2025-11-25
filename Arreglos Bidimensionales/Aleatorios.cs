using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Bidimensionales
{
    internal class Aleatorios
    {
        static void Main(string[] args)
        {
            /*Console.Write("Digite el orden de la matriz cuadrada para números con decimales aleatorios: ");
            int n = int.Parse(Console.ReadLine());

            Random ran = new Random();

            int[,] matriz = new int[n, n];

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    matriz[f, c] = ran.Next(0, 21);
                    Console.Write(matriz[f, c] + "     ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();*/



            Console.Write("Digite el orden de la matriz cuadrada para números con decimales aleatorios: ");
            int n = int.Parse(Console.ReadLine());

            Random ran = new Random();

            double[,] matriz = new double[n, n];

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    matriz[f, c] = Math.Round(ran.NextDouble() * 20, 2);
                    Console.Write(matriz[f, c] + "     ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}