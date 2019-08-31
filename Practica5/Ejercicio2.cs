using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int num;
            bool condicion;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un número entero");
                condicion = int.TryParse(Console.ReadLine(), out num);
            } while (condicion == false);
            Console.WriteLine(Demostrar(num));
            Console.ReadKey();       
                      
        }
        static string Demostrar(int num)
        {
            if (num < 0)
            {
                return "El número es negativo";
            }
            else if (num > 0)
            {
                return "El número es positivo";
            }
            return "El número es 0";
        }
    }
}
