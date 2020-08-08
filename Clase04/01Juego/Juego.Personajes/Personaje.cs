using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Personajes
{
    public abstract class Personaje
    {
        public int PosicionX { get; set; }

        public int PosicionY { get; set; }

        public string Nombre { get; set; }

        public Personaje(string nombre)
        {
            Nombre = nombre;
        }

        public abstract void Mover();
    }
}
