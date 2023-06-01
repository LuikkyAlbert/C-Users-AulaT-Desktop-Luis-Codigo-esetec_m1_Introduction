using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dado La edad de una persona decir es mayor de edad

            int edad;

            Console.WriteLine(" Por favor intruduzca una edad para determinar si es mayor de edad: \n");
            edad = Convert.ToInt32(Console.ReadLine());
            

            if (edad >= 18)
            {
                Console.WriteLine("\n\n ¡¡ F E L I C I D A D E S !!   Usted es Mayor de Edad");
            }
            else 
            {
                Console.WriteLine("\n\n ¡¡ B U F !!   Vente cuando seas Mayor de Edad\n");
            }


            Console.WriteLine("\n\n      ...Presiona ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
