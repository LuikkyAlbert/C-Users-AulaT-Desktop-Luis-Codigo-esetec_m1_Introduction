using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion16
{
    public class Program
    {
        static void Main(string[] args)
        {

            Jugador jugador = new Jugador();

            jugador.nombre = "Pepe";
            jugador.puntuacion = 0;

            jugador.SetPuntuacion(20);
            jugador.SetPuntuacion(10);
            
            jugador.Mensaje();
            jugador.ImprimirJugador();

            Perro perro = new Perro();
            perro.nombre = "Toby";

            perro.ImprimirJugador();
            perro.Mensaje();

            Gato gato = new Gato();
            gato.nombre = "Garfield";

            gato.ImprimirJugador();
            gato.Mensaje();

            Random random = new Random();
            gato.SetPuntuacion(random.Next(10));
            gato.ImprimirJugador();
            Console.ReadKey();
        }
    }
}
