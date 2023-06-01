using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Entran Datos de Formulario y se Imprimen
            string entradaNombre, entradaEdad;

            Console.WriteLine("  -------- Formulario -------- \n");
            Console.WriteLine("\nEscribe Tu Nombre, Por Favor: \n");
            entradaNombre = Console.ReadLine();

            Console.WriteLine("\n\nEscribe Tú Edad, Por Favor: \n");
            entradaEdad = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\n\nTú Nombre es: " + entradaNombre + "\n\n Tú Edad es: " + entradaEdad);
            Console.WriteLine("\n\n......Presiona Enter Para Salir......");
            Console.ReadLine();
            */




            /* // Entra dos valores y se hacen operaciones
            string valor1, valor2;
            int resultado;

            Console.WriteLine("\nEntra el 1º número: ");
            valor1 = Console.ReadLine();
            

            bool result = int.TryParse(valor1, out resultado);
            if (result == false) 
            {
                Console.WriteLine("\n\nPor Favor Entre un número, NO una LETRA\n\n");
                Console.WriteLine("Entre el 1º número: \n");
                valor1 = Console.ReadLine();
            }

           
            Console.WriteLine("\n\nEntra el 2º número: ");
            valor2 = Console.ReadLine();


            bool result2 = int.TryParse(valor2, out resultado);
            if (result2 == false)
            {
                Console.WriteLine("\n\nPor Favor Entre un número, NO una LETRA\n\n");
                Console.WriteLine("Entra el 2º número: \n");
                valor2 = Console.ReadLine();
            }

            int entero1 = Convert.ToInt32(valor1);
            int entero2 = Convert.ToInt32(valor2);

            Console.Clear();
            Console.WriteLine("  ------ Los Resultados ------  ");

            //resultado = Convert.ToInt32(valor1) + Convert.ToInt32(valor2);
            Console.WriteLine("\n\n" + valor1 + " + " + valor2 + " = " + (entero1 + entero2));

           // resultado = Convert.ToInt32(valor1) - Convert.ToInt32(valor2);
            Console.WriteLine("\n\n" + valor1 + " - " + valor2 + " = " + (entero1 - entero2));

           // resultado = Convert.ToInt32(valor1) * Convert.ToInt32(valor2);
            Console.WriteLine("\n\n" + valor1 + " * " + valor2 + " = " + (entero1 * entero2));

           // resultado = Convert.ToInt32(valor1) / Convert.ToInt32(valor2);
            Console.WriteLine("\n\n" + valor1 + " / " + valor2 + " = " + (entero1 / entero2));

            Console.WriteLine("\n\n\n.......Presiona ENTER Para Salir ......");
            Console.ReadLine();
           
            */


            // Programa que indica a cuanto toca pagar a cada comensal de la cuenta de la comida

            //string comensalesTotales, cuentaTotal;
            float comensales;
            float pagoPersona, cuentaTotal;
            string cuenta;

            Console.WriteLine("\n Por Favor, Indique cuantos comensales son: ");
          //  comensalesTotales = Console.ReadLine();
            comensales = Convert.ToSingle(Console.ReadLine());
               
            Console.WriteLine("\n Por Favor, Ahora indíquenos de cuanto es la cuenta: ");
          //  cuentaTotal = Console.ReadLine();
           cuenta = Console.ReadLine();

           cuentaTotal = Convert.ToSingle(cuenta);
            
            Console.Clear();
           // pagoPersona = cuentaTotal / comensales;
            pagoPersona =cuentaTotal / comensales;
          // pagoPersona = Convert.ToInt32(cuentaTotal) / Convert.ToInt32(comensalesTotales);
            Console.WriteLine("\n Cada Comensal tiene que pagar: " + pagoPersona + "\n\nDe la cuenta total de: " + cuentaTotal);

            Console.ReadLine();
            Console.WriteLine("\n\n\n Por Favor, Presione una Tecla........");

        }
    }
}
