using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dada una edad, decir si es niño/a, adolescente o adulto
            //13 a 18 adolescente

            //Si le das a    ctrl + k + c   ->  Todo lo que está seleccionado se pone como comentado
            //Si le das a    ctrl + k + u   ->  Quita los comentarios

            int edad;

            Console.WriteLine("\n\n Introduce una edad para indicar en que etapa de su vida está: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad <= 12)
            {
                Console.WriteLine("\n El sujeto es un NIÑO");
            }
            else if (13 <= edad && edad < 18)
            {
                Console.WriteLine("\n El sujeto es un ADOLESCENTE");
            }
            else 
            {
                Console.WriteLine("\n El sujeto es un ADULTO");
            }
            
            
            Console.WriteLine("\n\n Presione ENTER para continuar");
            Console.ReadLine();
        }
    }
}
