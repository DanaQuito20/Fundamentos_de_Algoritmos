using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana5_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad, num, pares = 0, impares = 0, ceros = 0;

            Console.Write("Ingrese la cantidad de números: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine($"Ingrese número {i}: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0) ceros++;
                else if (num % 2 == 0) pares++;
                else impares++;
            }

            Console.WriteLine($"Número de pares: {pares}\nNúmero de impares: {impares}\nNúmero de ceros: {ceros}");
        }
    }
}
