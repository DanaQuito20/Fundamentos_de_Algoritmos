using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_C_
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {
            int año;

            Console.Write("Ingrese un año: ");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0) Console.WriteLine("Año bisiesto.");
            else Console.WriteLine("Año no bisiesto.");

            if (año % 2 == 0) Console.WriteLine("El año es par.");
            else Console.WriteLine("EL año es impar.");

            Console.ReadKey();
        }
    }
}
