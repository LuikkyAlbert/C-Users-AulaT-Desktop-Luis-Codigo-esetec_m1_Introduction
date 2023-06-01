using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0 al 4: Suspendido
            //5 al 6: Aprobado
            //7 al 8: Notable
            //9 al 10: Sobresaliente

            /*
            int nota;

            Console.WriteLine("\n Introduce la Nota: \n");
            nota = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            
            MiNota(nota);
            */

            for (int i = 0; i < 11; i++) 
            {
                MiNota(i);
            }

            GetMiNota(11);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        static public void GetMiNota(int nota) 
        {

            string notaString = "";

            Console.WriteLine("\n\n");

            switch (nota) 
            {

                case 0:                                   
                case 1:
                case 2:
                case 3:
                case 4:
                    notaString = "Suspendido";
                    break;

                case 5:
                case 6:
                    notaString = "Apronado";
                    break;

                case 7:
                case 8:
                    notaString = "Notable";
                    break;

                case 9:
                case 10:
                    notaString = "Sobresaliente";
                    break;

                default:
                    notaString = "Valor no esperado";
                    break;

            }
            
            Console.WriteLine(notaString);
        
        }

        static public void MiNota(int nota) 
        {
           
            if (nota >= 0 && nota < 5)
            {

                Console.WriteLine("\n\n Lo Siento, con el " + nota + " Estás SUSPENDIDO.");

            }
            else if (nota > 4 && nota < 7)
            {

                Console.WriteLine("\n\n Por los Pelos!!!! con el " + nota + " Estás APROBADO.");

            }
            else if (nota > 6 && nota < 9)
            {

                Console.WriteLine("\n\n Felicidades!!!! con el " + nota + " Tienes un NOTABLE.");

            }
            else
            {

                Console.WriteLine("\n\n Eres el Mejor!!!! con el " + nota + " Tienes un SOBRESALIENTE.");

            }

        }
    }
}
