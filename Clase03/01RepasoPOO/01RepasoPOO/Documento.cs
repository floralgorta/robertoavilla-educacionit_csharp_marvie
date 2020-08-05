using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RepasoPOO
{
    class Documento
    {
        public string TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public override string ToString()
        {
            return $"{TipoDocumento}-{NumeroDocumento}";
        }
    }
}
