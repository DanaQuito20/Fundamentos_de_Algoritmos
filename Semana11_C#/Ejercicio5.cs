using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11_C_
{
    internal class Ejercicio5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] num = new int [cantidad];
            int suma = 0;

            for (int i  = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num [i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < cantidad; i++)
            {
                suma += num[i];
            }

            Console.WriteLine($"\nLa suma es igual a {suma}.");

            Console.ReadKey();
        }
    }
}