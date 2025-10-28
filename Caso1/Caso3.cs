using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    internal class Caso3
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el número de notas aleatorias a generar: ");
            int numNotas = int.Parse(Console.ReadLine());

            double[]notas = new double[numNotas];
            Random rand = new Random();

            for (int i = 0; i < numNotas; i++)
            {
                //notas[i] = rand.NextDouble();
                notas[i] = Math.Round(rand.NextDouble() * (0 - 20) + 20, 2);
            }

            Console.WriteLine("\nNotas reales generadas");

            for (int i = 0; i < numNotas; i++)
            {
                Console.WriteLine(notas[i]);
            }

            Console.ReadKey();
        }
    }
}