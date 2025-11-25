using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_15
{
    internal class Ejercicio_4
    {
        static void Main(string[] args)
        {
            string continuar;

            do
            {
                Console.WriteLine("¡Benvenidos al registro de productos!");
                Console.WriteLine("1. Registrar");
                Console.WriteLine("2. Mostrar");
                Console.WriteLine("3. Modificar");
                Console.WriteLine("0. Salir");

                Console.Write("\nIngrese una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0: return;
                    case 1: Registrar(); break;
                    case 2: Mostrar();  break;
                    case 3: Modificar(); break;
                }
                Console.Write("\nPara continuar ingrese 'Si': ");
                continuar = Console.ReadLine();
                Console.Clear();
            } while (continuar == "Si");
        }

        static string[,] productos = new string[0, 3];
        static int cantidad = 0;

        static void Redimensionar(int tamano)
        {
            string[,] nuevo = new string[tamano, 3];
            for (int f = 0; f < cantidad; f++)
            {
                for (int c = 0; c < productos.GetLength(1); c++)
                {
                    nuevo[f, c] = productos[f, c];
                }
            }
            productos = nuevo;
        }

        static void Registrar()
        {
            Redimensionar(cantidad + 1);

            Console.Write("\nNombre del producto: ");
            productos[cantidad, 0] = Console.ReadLine();

            Console.Write("\nPrecio del producto: S/.");
            productos[cantidad, 1] = Console.ReadLine();

            Console.Write("\nStock del producto: ");
            productos[cantidad, 2] = Console.ReadLine();

            cantidad++;
            Console.WriteLine("\nProducto registrado correctamente.");
        }

        static void Mostrar()
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nProducto {i + 1}");
                Console.WriteLine($"Nombre: {productos[i, 0]}");
                Console.WriteLine($"Precio: {productos[i, 1]}");
                Console.WriteLine($"Stock: {productos[i, 2]}");
                Console.WriteLine();
            }
        }

        static void Modificar()
        {
            Console.Write("\nIngrese el número del producto: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice < 0 && indice >= cantidad) return;

            Console.WriteLine("Ingrese nuevo nombre: ");
            productos[indice, 0] = Console.ReadLine();

            Console.WriteLine("Ingrese nuevo precio: ");
            productos[indice, 1] = Console.ReadLine();

            Console.WriteLine("Ingrese nuevo stock: ");
            productos[indice, 2] = Console.ReadLine();

            Console.WriteLine("\nProducto modificado.");
        }
    }
}