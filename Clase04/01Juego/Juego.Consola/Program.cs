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
        const int DIMENSIONENUNCIADO = 100;
        const string NOMBREJUGADORPRINCIPAL = "IronMan";

        static void Main(string[] args)
        {
            Tablero miTablero = new Tablero
            {
                DimensionX = DIMENSIONENUNCIADO,
                DimensionY = DIMENSIONENUNCIADO
            };

            Console.WriteLine($"Estado del juego: {miTablero.Estado}");
            Console.WriteLine($"Estado del juego: {(int)miTablero.Estado}");

            //No puedo crear porque Personaje es Abstracta
            //Personaje personaje = new Personaje("SpiderMan");

            //miTablero.Poblacion[0] = personaje;
            //miTablero.AgregarPersonaje(personaje);

            JugadorPrincipal jugadorPrincipal = new JugadorPrincipal(NOMBREJUGADORPRINCIPAL);
            miTablero.AgregarPersonaje(jugadorPrincipal);

            JugadorNaturaleza jugadorNaturaleza;
            for (int i = 0; i < 10; i++)
            {
                jugadorNaturaleza = new JugadorNaturaleza($"Naturaleza {i}");
                miTablero.AgregarPersonaje(jugadorNaturaleza);
            }

            JugadorCPU jugadorCPU = new JugadorCPU("CPU");
            miTablero.AgregarPersonaje(jugadorCPU);

            for(int i = 0; i < 100; i++)
            {
                miTablero.MoverTodo();
                Console.WriteLine(miTablero);
            }

            miTablero.Finalizar();
            Console.WriteLine($"Estado del juego: {miTablero.Estado}");
            Console.WriteLine($"Estado del juego: {(int)miTablero.Estado}");

            Console.ReadKey();
        }
    }
}
