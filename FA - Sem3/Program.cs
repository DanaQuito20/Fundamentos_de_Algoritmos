using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA___Sem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ej2();
            Console.ReadKey();
        }


        static void ej1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso de Fundamentos de Algoritmos de la carrera de {carrera}.");
        }


        static void ej2()
        {
            Console.WriteLine("\"Danayra\"");
        }


        static void ej3()
        {

        }


        static void ej4()
        {
            double num, raizCuadrada, valorEntero, elevarCubo, raizCubica;

            Console.WriteLine("Ingrese un decimal: ");
            num = Convert.ToDouble(Console.ReadLine());
            raizCuadrada = Math.Sqrt(num);
            valorEntero = Math.Round(num);
            elevarCubo = Math.Pow(num, 3);
            
        }


        static void ej5()
        {

        }


        static void ej6()
        {

        }
    }
}