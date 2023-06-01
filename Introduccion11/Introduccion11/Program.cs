using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion11
{
    internal class Program
    {
        static void Main(string[] args)
        {
                   
            Random random = new Random(); // Para crear un número Aleatorio
           // int valor = random.Next(10);  // Asigna a valor un numero aleatoria comprendio entre random.Next(MenorValor, MaxValor)
            for (int cont = 0; cont < 6; cont++) 
            {
                int valor = random.Next(6);
                
                Console.WriteLine("\n" + valor);
            }
            //  Console.WriteLine(valor);

            int num1 = random.Next(100);
            int num2 = random.Next(100);

            Console.WriteLine("\n Valor 1: " + num1 + "\n Valor 2: " + num2);
            Console.WriteLine("\n" + (num1 + num2));


            Console.ReadKey();
        }
    }
}
