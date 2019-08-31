using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            double precio, descuento;
            bool condicion;
            do
            {
            Console.Clear();
            Console.WriteLine("Ingrese el precio del producto: ");
            condicion = double.TryParse(Console.ReadLine(), out precio);
            } while (condicion == false || precio <= 0);
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el descuento del producto:\n***Ejemplo: 0.15***");
                condicion = double.TryParse(Console.ReadLine(), out descuento);
            } while (condicion == false || descuento < 0);
            Console.WriteLine("El subtotal es: " + precio.ToString("c2"));
            if (descuento > 0)
            {
                Console.WriteLine("El total con descuento incluido es: " + Descuento(precio, descuento).ToString("c2"));                
            }
            else Console.WriteLine("El total es:" + precio.ToString("c2"));
            Console.ReadKey();
        }
        static double Descuento(double precio, double descuento=0)
        {
            double des;            
            des = precio * descuento;
            des = precio - des;
            return des;
        }
    }
}
