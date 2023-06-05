using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion16
{
    public class Jugador
    {
        public string nombre;
        public int puntuacion;

        public void SetPuntuacion(int puntos) 
        {
            puntuacion = puntuacion + puntos;            
        }

        public void ImprimirJugador() 
        {
            Console.WriteLine();
            Console.Write("Nombre: " + nombre + " --> ");
            Console.Write("Puntuación: " + puntuacion);        
        }

        public void Mensaje() // public virtual void Mensaje(); (Poliformismo son los numbres igual)  El padre no lo va Usar sino los hijos que los herederan
        {
            Console.WriteLine("\nSoy BATMAN\n");
        }

    }


}
