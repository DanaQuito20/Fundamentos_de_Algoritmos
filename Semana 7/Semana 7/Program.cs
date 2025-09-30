using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Utilizando For
            Console.WriteLine("Caso con For: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            //Utilizando While
            Console.WriteLine("\nCaso con While: ");
            int j = 1;
            while (j <= 10)
            {
                Console.Write(j + " ");
                j++;
            }

            //Utilizando Do While
            Console.WriteLine("\nCaso con Do While: ");
            int k = 1;
            do
            {
                Console.Write(k + " ");
                k++;
            } while (k <= 10);

            Console.ReadKey();*/





            /*//Utilizando For
            Console.WriteLine("Caso con For: ");
            for (int i = 10; i >= 1; i--)
            {
                Console.Write(i + " ");
            }

            //Utilizando While
            Console.WriteLine("\nCaso con While: ");
            int j = 10;
            while (j >= 1)
            {
                Console.Write(j + " ");
                j--;
            }

            //Utilizando Do While
            Console.WriteLine("\nCaso con Do While: ");
            int k = 10;
            do
            {
                Console.Write(k + " ");
                k--;
            } while (k >= 1);

            Console.ReadKey();*/





            //Casuística 1
            /*int estudiantes, i = 1, edad, suma = 0;
            double promedio;

            Console.Write("Ingrese la cantidad de estudiantes: ");
            estudiantes = int.Parse(Console.ReadLine());

            while (i <= estudiantes)
            {
                Console.Write($"Ingrese la edad del estudiante {i}: ");
                edad = int.Parse(Console.ReadLine());
                i++;
                suma += edad;
            }

            promedio = suma * 1.0 / estudiantes;

            Console.WriteLine($"El promedio de los {estudiantes} estudiantes es de {promedio}");

            Console.ReadKey();*/



            //Casuística 2
            int estudiantes, i = 1, edad, menorE = 0, mayorE = 0;

            Console.Write("Ingrese la cantidad de estudiantes: ");
            estudiantes = int.Parse(Console.ReadLine());

            while (i <= estudiantes)
            {
                Console.Write($"Ingrese la edad de la persona {i}: ");
                edad = int.Parse(Console.ReadLine());
                i++;
                
                if (edad < 18) menorE++;
                else mayorE++;
            }

            Console.WriteLine($"Hay {menorE} estudiantes menores de edad y {mayorE} estudiantes mayores de edad");

            Console.ReadKey();
        }
    }
}
