using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables

            int numero1, numero2, resultado, multiplicacion, resta;

            numero1 = 10;
            numero2 = 20;


            //Lógica del Programa

            resultado = numero1 + numero2;
            multiplicacion = numero1 * numero2;
            resta = numero1 - numero2;

            if (numero1 < numero2)
            {
                resta = numero1 - numero2;
                Console.WriteLine(numero1 + " < " + numero2 + "\n\n");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine(numero1 + " > " + numero2 + "\n\n");
            }
            else if (numero1 == numero2) 
            {
                Console.WriteLine(numero1 + " = " + numero2 + "\n\n");
            }

            //Visualización

            Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado + "\n");
            Console.WriteLine(numero1 + " * " + numero2 + " = " + multiplicacion + "\n");
            Console.WriteLine(numero1 + " - " + numero2 + " = " + resta + "\n");
            Console.ReadKey();
        }
    }
}
