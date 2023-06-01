using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int valor1 = 5, valor2 = 10, suma;

            //suma = valor1 + valor2;

            //Console.WriteLine(suma);

            //for (int cont = 0; cont < 11; cont++)
            //{
            //    Hola();
            //}

            Mensaje("\n Hola Mundo Cruel");
            Mensaje("\n Adios");

            int num1, num2, resultado;

            char valor;

            for (int cont = 1; cont >= 0; cont++) 
            {
               
                Console.WriteLine("¿Qué cálculo quieres hacer?");
                valor = Convert.ToChar(Console.ReadLine());

                if (valor == '.')
                {
                    break;
                }

                Console.WriteLine("\n Entra el 1º número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n Entra el 2º número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                switch (valor)
                {

                    case '+':
                        resultado = Suma(num1, num2);
                        Console.WriteLine(resultado);
                        break;

                    case '-':
                        resultado = Resta(num1, num2);
                        Console.WriteLine(resultado);
                        break;

                    case '/':
                        resultado = Division(num1, num2);
                        Console.WriteLine(resultado);
                        break;

                    case '*':
                        resultado = Multiplicacion(num1, num2);
                        Console.WriteLine(resultado);
                        break;    

                }

            }

            //int suma, num3;

            //Console.WriteLine("\n Entra el 3º número: ");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //suma = Suma(num1, num2, num3); // Es igual que haber puesto una linea más diciendo sum = Suma (suma, 30);

           // Console.WriteLine("\n\n" + suma);
            Console.ReadLine();
        }

        static public void Mensaje(string saludo) 
        {

            Console.WriteLine(saludo);

        }


        static public int Suma(int valor1, int valor2) 
        { 
        
           // Console.WriteLine("\n\n" + (valor1 + valor2));

            return valor1 + valor2;
          
        }

        static public int Resta(int valor1, int valor2) 
        {

            return valor1 - valor2;
        
        }

        static public int Multiplicacion(int valor1, int valor2) 
        { 
        
            return valor1 * valor2;
        
        }

        static public int Division(int valor1, int valor2) 
        { 
        
            return (valor1 / valor2);

        }
    }
}
