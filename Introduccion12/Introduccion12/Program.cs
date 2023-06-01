using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // XXXXXXXX
            // X      X
            // X      X
            // X      X
            // XXXXXXXX

           Console.ForegroundColor = ConsoleColor.DarkBlue;
           Console.BackgroundColor = ConsoleColor.DarkYellow;

            Metodo();

            Console.ReadKey();

        }

        static public void Metodo() 
        {

            for (int colum = 0; colum < 10; colum++ ) 
            {
                             
                    for (int fila = 0; fila < 10; fila++)
                    {
                        if ((fila == 0 || fila == 9) || (colum == 0 || colum == 9))
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }            

                Console.WriteLine();
            
            }
        
        }
    }
}
