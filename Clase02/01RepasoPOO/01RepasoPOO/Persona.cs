using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RepasoPOO
{
    /*
     * Modificadores de CLASES
     * internal (por defecto): Es visible dentro del mismo Proyecto (assembly)
     * public: Es visible dentro y fuera del proyecto
     * private: Utilizable solo por una clase
     */
    class Persona
    {
        /*
         * Modificadores de MIEMBROS (Atributos y los metodos)
         * protected (por defecto): Visible para el propio objeto y para los hijos
         * public: Visible para todos
         * private: Visible unicamente para el propio objeto
         */

        // No tiene encapsulamiento!!!
        public string nombre;
        // No tiene encapsulamiento!!!
        public string apellido;

        public Documento Documento { get; set; }

        public Persona()
        {
        }

        public Persona(Documento documento,string apellido)
        {
            this.Documento = documento;
            this.apellido = apellido;
        }

        public virtual string ObtenerCodigoPersona()
        {
            return $"({Documento}){apellido}";
        }
    }
}
