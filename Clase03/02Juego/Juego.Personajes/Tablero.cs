using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Personajes
{
    public class Tablero
    {
        public int DimensionX { get; set; }

        public int DimensionY { get; set; }

        public Personaje[] Poblacion { get; set; } = new Personaje[0];

        public void AgregarPersonaje(Personaje personaje)
        {
            Personaje[] aux = new Personaje[Poblacion.Length + 1];
            
            for(int i = 0; i < Poblacion.Length; i++)
            {
                aux[i] = Poblacion[i];
            }

            aux[aux.Length-1] = personaje;

            Poblacion = aux;
        }

        public override string ToString()
        {
            return $"Tablero {DimensionX}x{DimensionY}";
        }
    }
}
