using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // int[] alumno = new int[];
            int numeroAlumnos = 10;
            
            GenerarNotas(numeroAlumnos);
            SumarNotas(numeroAlumnos);
            MayorNota(numeroAlumnos);
            
            Console.ReadKey();
        }

        static public void MayorNota(int numeroAlumnosInterno) 
        {

            int[] notas = new int[numeroAlumnosInterno];
            int mayor = 0, repeticion = 0;
            Random rand = new Random();
            
            // Para crear notas aleatorias del 0 al 10
            for (int cont = 0; cont < numeroAlumnosInterno;cont++)
            {
                notas[cont] = rand.Next(11);
            }

            // Para saber que nota es la mayor que se sacó
            for (int cont = 0; cont < numeroAlumnosInterno; cont++) 
            {

                if (notas[cont] > mayor) 
                {
                    mayor = notas[cont];
                }
            
            }

            // Para saber cuantas personas sacaron la máxima nota
            for (int cont = 0; cont < numeroAlumnosInterno; cont++) 
            {

                if (notas[cont] == mayor) 
                {
                    repeticion ++;
                }
            
            }


            // Visualización de los resultados

            Console.WriteLine("\n\n\nActialización de Notas: \n");

            for (int cont = 0; cont < numeroAlumnosInterno; cont++) 
            {
                Console.WriteLine("Alumno" + (cont + 1) + ": " + notas[cont]);
            }

            Console.WriteLine("\n La nota mayor es el: " + mayor);
            Console.WriteLine("\n El numero de veces que ha salido la nota mayor es de: " + repeticion);

        }

        static public void SumarNotas(int numeroAlumnosInterno)
        {
            int[] notas = new int[numeroAlumnosInterno];
            int[] notas2 = new int[numeroAlumnosInterno];

            Random rand = new Random();

            for (int cont = 0; cont < numeroAlumnosInterno; cont++) 
            {

                notas[cont] = rand.Next(11);
                notas2[cont] = rand.Next(11);
            
            }

            Console.WriteLine("\n");

            for (int cont = 0; cont < numeroAlumnosInterno; cont++) 
            {
                Console.WriteLine(" Notas Grupo A: " + notas[cont] + "     Nota Grupo B: " + notas2[cont]);
            }                        
        }

        static public void GenerarNotas(int numeroAlumnosInterno)
        {
            int[] notas = new int[numeroAlumnosInterno];
            int suma = 0, mediaNotas = 0;

            Random rand = new Random();
           // int valor = rand.Next(10);


            //Genera las notas de forma aleatoria
            for (int cont = 0; cont < numeroAlumnosInterno; cont++)
            {
                notas[cont] = rand.Next(11);               
            }


            // Suma todas las notas
            for (int cont = 0; cont < numeroAlumnosInterno; cont++)
            {
                suma = suma + notas[cont];
            }


            mediaNotas = suma / numeroAlumnosInterno;


            // Saca los resultados en Pantalla
            for (int cont = 0; cont < numeroAlumnosInterno; cont++) 
            {
                Console.WriteLine("Alumno " + (cont + 1) + " -> " + notas[cont]);            
            }


            Console.WriteLine("\n La suma TOTAL de las NOSTAS es: " + suma);
            Console.WriteLine("\n La Media de las notas en total es " + mediaNotas);
        
        }

    }
}
