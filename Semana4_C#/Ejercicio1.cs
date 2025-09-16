using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_C_
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {
            int edad;

            Console.Write("Ingrese una edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Menor de edad");
            else if (edad <= 64) Console.WriteLine("Adulto");
            else Console.WriteLine("Adulto mayor");

            Console.ReadKey();
        }
    }
}
