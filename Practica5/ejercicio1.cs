using System;
//Julio Israel Aguilar Melgar
namespace Practica5
{
    class ejercicio1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Los dias restantes que faltan son: " + Diasrestantes());
            Console.ReadKey();
        }

        static int Diasrestantes()
        {
            return 365 - DateTime.Now.DayOfYear;
            
        }
    }
}
