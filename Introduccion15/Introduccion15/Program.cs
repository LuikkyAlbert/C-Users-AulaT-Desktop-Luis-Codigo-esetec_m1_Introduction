using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            Random random = new Random();                     
            int puntos = 0;

            puntos = random.Next(11);


            // Si tienes mas 50 puntos escribir VIVA GRINDIRFOLFS

            Console.WriteLine("\n Puntos: " + puntos);

            if (puntos > 5)
            {               
                Console.WriteLine("\n ¡¡¡ VIVA GRINDIRFOLFS !!!");
            }
            else 
            {
                Console.WriteLine("\n PUFFFFF ¡¡¡ FRACASADO !!!\n\n JAJAJAJAJAJAJAJAJAJAJAJAJAJAJA");
            }


            //Si estás entre 30 y 50 decir Pringao! haber estudiado más

            if (puntos > 3 && puntos < 5) 
            { 
                Console.WriteLine("\n\n ¡¡¡Pringado!!! Tenías que haber Puesto más los codos JAJAJAJAJA");
            }

            if (puntos > 10) 
            {
                Console.WriteLine("\n CONGRATULENCION");
            }

            // Si es diferente

            if (puntos != 0) 
            { 
                Console.WriteLine("\n Algo Tienes, no te queeeejeeees mi niño!");
            }

            // Si Tienes 6 ó 7 puntos escribir bastante bien

            if (puntos == 6 || puntos == 7) 
            {
                Console.WriteLine("\n Bueno ahí, ahí");
            }
            
            Console.ReadKey();
        }
    }
}
