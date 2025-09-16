using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_C_
{
    internal class Ejercicio3
    {
        static void Main(string[] args)
        {
            double montoS, montoD, montoE;
            int cambio;

            Console.Write("Ingrese su monto en soles:");
            montoS = double.Parse(Console.ReadLine());

            Console.WriteLine("Tipos de cambio");
            Console.WriteLine("1. Soles a dólares");
            Console.WriteLine("2. Soles a euros");
            Console.Write("Eliga su tipo de cambio: ");
            cambio = int.Parse(Console.ReadLine());

            switch (cambio)
            {
                case 1:
                    montoD = montoS / 3.75;
                    Console.WriteLine($"Su monto final es de {montoD:F2}"); break;
                case 2:
                    montoE = montoS / 4.05;
                    Console.WriteLine($"Su monto final es de {montoE:F2}"); break;
                default:
                    Console.WriteLine("Ingrese de nuevo un valor correcto.");break;
            }

            Console.ReadKey();
        }
    }
}
