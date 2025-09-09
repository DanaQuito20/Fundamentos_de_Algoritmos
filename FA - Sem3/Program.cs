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
            ej4();
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
            int num1, num2, suma, resta, multiplicacion;
            double division;

            Console.Write("Ingrese número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número 2: ");
            num2 = int.Parse(Console.ReadLine());

            suma = num1 + num2;
            resta = num1 - num2;
            multiplicacion = num1 * num2;
            division = (double)num1 / (double)num2;

            Console.WriteLine($"La suma es {suma}, la resta es {resta}, la multiplicación es {multiplicacion} y la división es {division}.");
        }


        static void ej4()
        {
            double num, raizCuadrada, valorEntero, elevarCubo, raizCubica;

            Console.Write("Ingrese un decimal: ");
            num = Convert.ToDouble(Console.ReadLine());

            raizCuadrada = Math.Sqrt(num);
            valorEntero = Math.Round(num);
            elevarCubo = Math.Pow(num, 3);
            raizCubica = Math.Pow(num, 1.0 / 3.0);

            Console.WriteLine($"La raíz cuadrada es {raizCuadrada}, el valor redondeado es {valorEntero}, el resultado de elevar al cubo es {elevarCubo} y la raíz cúbica es {raizCubica}.");
        }


        static void ej5()
        {

        }


        static void ej6()
        {

        }
    }
}