using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Juego.Personajes;

namespace Juego.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero miTablero = new Tablero
            {
                DimensionX = 100,
                DimensionY = 100
            };

            Personaje personaje = new Personaje();

            //miTablero.Poblacion[0] = personaje;
            miTablero.AgregarPersonaje(personaje);

            Console.WriteLine(miTablero);

            Console.ReadKey();
        }
    }
}
