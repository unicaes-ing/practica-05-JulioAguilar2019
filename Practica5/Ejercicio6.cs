using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promedio: " + Lista(10.0,5.5,9.0,3.0,6.0,7.0,8.0,5.0).ToString("0.00"));
            Console.ReadKey();
        }

        static double Lista(params double[] notas)
        {
            double total = 0.0;
            foreach (var item in notas)
            {
                total += item;
            }
            return total / notas.Length;
        }
    }
}
