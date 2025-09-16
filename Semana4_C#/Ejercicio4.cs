using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4_C_
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("Bienvenidos al cálculo de áreas");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectángulo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Círculo");
            Console.Write("Ingrese una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int lado, aC;

                    Console.Write("Ingrese el lado: ");
                    lado = int.Parse(Console.ReadLine());

                    aC = lado * lado;

                    Console.WriteLine($"El área del cuadrado es de {aC}"); break;
                case 2:
                    int largo, ancho, aR;

                    Console.Write("Ingrese el largo: ");
                    largo = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ancho: ");
                    ancho = int.Parse(Console.ReadLine());

                    aR = largo * ancho;

                    Console.WriteLine($"El área del rectángulo es de {aR}"); break;
                case 3:
                    int bse, altura, aT;

                    Console.Write("Ingrese la base: ");
                    bse = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    altura = int.Parse(Console.ReadLine());

                    aT = (bse * altura) / 2;

                    Console.WriteLine($"El área del triángulo es de {aT}"); break;
                case 4:
                    double radio, aCi;

                    Console.Write("Ingrese el radio: ");
                    radio = int.Parse(Console.ReadLine());

                    aCi = Math.Round(Math.PI * (radio * radio), 2);

                    Console.WriteLine($"El área del círculo es de {aCi}"); break;
                default:
                    Console.WriteLine("El valor ingresado es incorrecto, vuelva a ingresar otro correctamente."); break;
            }

            Console.ReadKey();
        }
    }
}
