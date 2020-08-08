using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Personajes
{
    public class JugadorPrincipal: Personaje
    {
        public JugadorPrincipal(string nombre) : base(nombre)
        {

        }
        public override void Mover()
        {
            PosicionX += 2; //Equivalente a hacer PosicionX = PosicionX + 2;
            PosicionY += 2; //Equivalente a hacer PosicionY = PosicionY + 2;
        }
    }
}
