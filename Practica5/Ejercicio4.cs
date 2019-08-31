using System;
using System.Collections.Generic;
using System.Text;

namespace Practica5
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            string num1, num2, num3, num4;
            Console.WriteLine("Ingrese el primer número de telefono");
            num1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segunddo número de telefono");
            num2 = Console.ReadLine();
            Console.WriteLine("Ingrese el tercer número de telefono");
            num3 = Console.ReadLine();
            Console.WriteLine("Ingrese el cuarto número de telefono");
            num4 = Console.ReadLine();
        }
        static string Aleatorio(string num1, string num2, string num3, string num4)
        {

            Random random = new Random();
            int num = random.Next(1, 5); 
            
            if (num == 1)
            {
                return num1;
            }
            if (num == 2)
            {
                return num2;
            }
            if (num == 3)
            {
                return num3;
            }
            return num4;
        }
    }
}
