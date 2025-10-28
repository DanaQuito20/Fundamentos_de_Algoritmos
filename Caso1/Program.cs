using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite cantidad de edades a ingresar: ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] edades = new int[cantidad]; //Vector para almacenar "n" edades

            int suma = 0, edadesP = 0, edadesI = 0;

            for (int i = 0; i < cantidad; i++)
            {
                edades[i] = int.Parse(Console.ReadLine());
                suma += edades[i]; //suma = suma + edades[i]
                if (edades[i] % 2 == 0) edadesP++;
                else edadesI++;
            }

            Console.WriteLine("\nEdades ingresadas:");

            for (int i = 0; i < cantidad; i++) //Para visualizar las edades ingresadas
            {
                Console.WriteLine(edades[i]);
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"La edad en la posición {i} es: {edades[i]}");
            }
           
            Console.WriteLine($"\nLa suma de las edades es {suma}");

            Console.WriteLine($"\nEl promedio de las edades es {suma * 1.0 / cantidad}");

            Console.WriteLine($"\nHay {edadesP} edades pares y {edadesI} edades impares");

            Console.ReadKey();
        }
    }
}