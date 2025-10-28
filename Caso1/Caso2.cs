using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    internal class Caso2
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el número de notas aleatorias a generar: ");
            int numNotas = int.Parse(Console.ReadLine());

            int[]notas = new int[numNotas];
            Random rand = new Random();

            int notasMin = 0, notasMax = 0;

            for (int i = 0; i < numNotas; i++)
            {
                notas[i] = rand.Next(0, 21); //notas[i] = rand.Next(mín, máx + 1)
                if (notas[i] == 0) notasMin++;
                if (notas[i] == 20) notasMax++;
            }

            Console.WriteLine("\nLista de notas creadas de forma aleatoria");

            for (int i = 0; i < numNotas; i++)
            {
                if (notas[i] == 0) Console.WriteLine($"{notas[i]} -> Nota mínima");
                else if (notas[i] == 20) Console.WriteLine($"{notas[i]} -> Nota máxima");
                else Console.WriteLine(notas[i]);
            }

            Console.WriteLine($"\nLas notas mínimas son {notasMin} y las notas máximas son {notasMax}.");

            Console.ReadKey();
        }
    }
}