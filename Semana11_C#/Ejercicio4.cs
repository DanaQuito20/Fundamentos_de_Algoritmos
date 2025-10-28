using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11_C_
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            int[] numero = new int[10];

            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                numero[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros ingresados:");

            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }

            Console.Write("\nNúmeros pares: ");

            for (int i = 0;i < numero.Length;i++)
            {
                if (numero[i] % 2 == 0) Console.Write($"{numero[i]}, ");
            }

            Console.ReadKey();
        }
    }
}