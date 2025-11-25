using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (f == c) matriz[f, c] = 0;
                    else matriz[f, c] = 5;
                    Console.Write(matriz[f, c] + "     ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}