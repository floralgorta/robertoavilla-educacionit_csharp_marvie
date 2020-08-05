using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RepasoPOO
{
    interface IIdentificable
    {
        string Identificador { get; set; }

        string ObtenerIdentificador();
    }
}
