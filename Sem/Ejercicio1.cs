using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            int numero, numeroP = 0, numeroI = 0;

            do
            {
                Console.Write("Ingrese un número entero (negativo para finalizar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0) continue;

                if (numero % 2 == 0) numeroP++;
                else numeroI++;
            } while (numero > 0);

            Console.WriteLine($"\nLa cantidad de pares es de {numeroP} y la cantidad de impares es de {numeroI}.");

            Console.ReadKey();
        }
    }
}
