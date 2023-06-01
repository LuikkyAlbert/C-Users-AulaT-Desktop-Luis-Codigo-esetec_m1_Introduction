using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tabla de multiplicar

            for (int tabla = 0; tabla < 11; tabla++)
            {

                for (int indice = 0; indice < 11; indice++) 
                {

                    Console.WriteLine(tabla + " * " + indice + " = " + (tabla * indice));
                
                }

                Console.WriteLine("\n");

            }

            Console.WriteLine(int.MaxValue); //Para ver al número máximo que soporta un entero

            for (int num = 0; num < 11; num++) 
            {

                if (num % 2 == 0)
                {
                    Console.WriteLine("\n Par: " + num);
                }
                else 
                {

                    Console.WriteLine("\n Impar: " + num);
                
                }

            }

            Console.WriteLine("\n\n\n\n ... Presiona ENTER para Salir ...");
            Console.ReadKey();

        }
    }
}
