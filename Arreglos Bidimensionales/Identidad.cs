using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Bidimensionales
{
    internal class Identidad
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el orden de la matriz identidad: ");
            int n = int.Parse(Console.ReadLine());

            int[,]identidad = new int [n, n];

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (f == c) identidad[f, c] = 1;
                    Console.Write(identidad[f, c] + "     ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}