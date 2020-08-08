using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Personajes
{
    public class JugadorSecundario : Personaje
    {
        public JugadorSecundario(string nombre) : base(nombre)
        {

        }

        public override void Mover()
        {
            PosicionX += 3;
            PosicionY += 3;
        }
    }
}
