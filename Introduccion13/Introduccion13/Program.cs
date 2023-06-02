using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAlumnos = 10;
            int[] notas = new int[numeroAlumnos];
            int suma = 0;

            notas[0] = 4;
            notas[1] = 5;
            notas[2] = 8;
            notas[3] = 7;
            notas[4] = 9;

            Console.WriteLine(notas[0]);
            Console.WriteLine(notas[1]);
            Console.WriteLine(notas[2]);

            for (int cont = 0; cont < numeroAlumnos; cont++) 
            {
                suma = suma + notas[cont];
            }

            Console.WriteLine("\n" + suma);
            
            Console.ReadKey();



        }
    }
}
