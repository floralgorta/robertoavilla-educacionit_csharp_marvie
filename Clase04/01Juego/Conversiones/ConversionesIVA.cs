using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    public static class ConversionesIVA
    {
        public static decimal AgregarIva(decimal valor)
        {
            return valor * 1.21m;
        }

        public static decimal QuitarIva(decimal valor)
        {
            return valor / 1.21m;
        }
    }
}
