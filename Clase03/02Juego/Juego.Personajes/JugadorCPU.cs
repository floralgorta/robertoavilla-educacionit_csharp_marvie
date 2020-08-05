using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Personajes
{
    public class JugadorCPU: Personaje
    {
        public override void Mover()
        {
            PosicionX += 2;
            PosicionY += 1;
        }
    }
}
