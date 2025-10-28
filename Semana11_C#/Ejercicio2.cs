using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11_C_
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            int[] numero = {-2, 5, -1, 0, 8, -6, 3};

            Console.Write("Los números son estos: ");
            foreach (int i in numero)
            {
                Console.Write($"{i}, ");
            }

            Console.Write($"\nNúmeros reemplazados: ");

            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] < 0) numero[i] = 0;
                Console.Write($"{numero[i]}, ");
            }

            Console.ReadKey();
        }
    }
}