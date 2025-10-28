using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    internal class Caso4
    {
        static void Main(string[] args)
        {
            Console.Write("Digite la cantidad de sueldos enteros de 4 dígitos a generar: ");
            int cantSueldos = int.Parse(Console.ReadLine());

            int[] sueldos = new int[cantSueldos];
            Random rand = new Random();

            for(int i = 0; i < cantSueldos; i++)
            {
                sueldos[i] = rand.Next(1000, 10000); //sueldos[i] = rand.Next(mín, máx + 1)
            }

            Console.WriteLine("\nLista de sueldos generados");

            for (int i = 0; i < cantSueldos; i++)
            {
                Console.WriteLine(sueldos[i]);
            }

            int sueldoMin = sueldos[0];

            for (int i = 0; i < cantSueldos; i++)
            {
                if (sueldos[i] < sueldoMin) sueldoMin = sueldos[i];
            }

            Console.WriteLine($"\nEl sueldo mínimo es {sueldoMin}.");

            Console.ReadKey();
        }
    }
}