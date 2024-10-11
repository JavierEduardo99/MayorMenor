using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorAmenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            // Ingresar los tres números
            Console.WriteLine("Ingresa el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer número:");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("************************************");

            // Comparar cuál número es el mayor
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El primer número es el mayor.");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El segundo número es el mayor.");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("El tercer número es el mayor.");
            }
            else
            {
                Console.WriteLine("Hay al menos dos números iguales.");
            }
            Console.ReadLine();
        }
    }
}
