using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            int num=0;
            bool condicion;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un número para calcular su factorial");
                condicion = int.TryParse(Console.ReadLine(), out num);
            } while (condicion == false || num < 0);            
            Console.WriteLine("El factorial del "+ num + " es: " + Factorial(num));
            Console.ReadKey();
        }
        static int Factorial(int num)
        {
            
            int total=1;
            for (int i = 1; i <= num; i++)
            {
                total *= i;
            }
            if (num == 0)
            {
                return 0;
            }
            return total;
        }
    }
}
