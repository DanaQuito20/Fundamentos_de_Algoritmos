using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Librería
{
    public class CuatroOperaciones
    {
        public static int Suma(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Resta(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiplicación(int n1, int n2)
        {
            return n1 * n2;
        }

        public static double División(int n1, int n2)
        {
            return n1 * 1.0 / n2; 
        }

        public static string EstadoNum(int n1, int n2)
        {
            if (n1 == n2) return "Los números son iguales";
            else if (n1 > n2) return $"El número mayor es {n1} y el número menor es {n2}";
            else return $"El número mayor es {n2} y el número menor es {n1}";
        }
    }
}