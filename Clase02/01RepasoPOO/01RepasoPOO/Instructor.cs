using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RepasoPOO
{
    class Instructor: Persona
    {
        public int CantidadCursosAsignados { get; set; }

        public override string ObtenerCodigoPersona()
        {
            return $"({Documento})INST-{apellido}";
        }
    }
}
