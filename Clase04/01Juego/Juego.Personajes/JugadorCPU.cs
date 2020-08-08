using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Personajes
{
    public class JugadorCPU : Personaje
    {

        public JugadorCPU(string nombre) : base(nombre)
        {

        }

        // Dejo comentado porque quiero obligar a que todos tengan nombre, pero tambien podria hacer:
        //public JugadorCPU() : base("JUGADORCPU")
        //{
        //}

        public override void Mover()
        {
            PosicionX += 2;
            PosicionY += 1;
        }
    }
}
