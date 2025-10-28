using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11_C_
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            int[] numero = {10, 50, 6, 3, 7, 20};

            Console.Write("Números: ");

            foreach (int i in numero)
            {
                Console.Write($"{i}, ");
            }

            int minimo = numero[0], maximo = numero[0];

            for (int i = 1; i < numero.Length; i++)
            {
                if (numero[i] < minimo) minimo = numero[i];
                if (numero[i] > maximo) maximo = numero[i];
            }

            Console.WriteLine($"\nEl mínimo es {minimo} y el máximo es {maximo}.");

            Console.ReadKey();
        }
    }
}