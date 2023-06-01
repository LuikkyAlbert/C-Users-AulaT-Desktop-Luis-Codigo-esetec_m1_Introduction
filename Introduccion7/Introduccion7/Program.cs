using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprime en pantalla los números pares del 0 al 10

            int resultado = 1;
            
            Console.WriteLine("\n Números Pares -> \n");
            
            for (int indice = 0; indice < 11; indice += 2) 
            { 

                Console.Write(indice + " ");

            }

            Console.WriteLine("\n\n\n\n Números impares -> \n");

            for (int indice = 1; indice < 11; indice += 2) 
            {

                Console.Write(indice + " ");

            }

            Console.WriteLine("\n\n\n\n Número Factorial de 5 -> \n");

            for (int indice = 5; indice > 0; indice--) 
            {

                resultado = resultado * indice;

            }

            Console.Write("El valor es: " + resultado);

            resultado = 0;

            Console.WriteLine("\n\n\n\n Sumatoria de los 5 primeros números -> \n");

            for (int indice = 0; indice <6; indice++) 
            {
                resultado = resultado + indice;
            }

            Console.WriteLine("El valor es: " + resultado);



            Console.WriteLine("\n\n\n\n\n ...Presione ENTER para salir ...");
            Console.ReadLine();
        }
    }
}
