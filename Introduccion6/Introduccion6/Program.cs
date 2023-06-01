using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa que saca numeros del cero al 10

            int multiplicacion = 0, tabla = 5;

            for (int numero = 0; numero < 11; numero++) 
            {
                Console.WriteLine($"{numero} ");
            }

            Console.WriteLine("\n");

            for (int indice = 9; indice >=0; indice--) 
            {
                Console.WriteLine($"{indice} ");
            }

            Console.WriteLine("\n");

            for (int indice = 0; indice <11; indice++) 
            {
               
                multiplicacion = tabla * indice;
                Console.WriteLine(tabla + " * " + indice + " = " + multiplicacion);
                
            }
            
            
            Console.WriteLine("\n  ... Presiona ENTER para salir ...");
            Console.ReadLine();
        }
    }
}
