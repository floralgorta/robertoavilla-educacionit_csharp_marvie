using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RepasoPOO
{
    class Curso: IIdentificable
    {
        public Instructor InstructorCurso { get; set; }
        public string Identificador { get; set; }

        public Alumno[] Alumnos = new Alumno[30];

        public Persona[] ObtenerParticipantes()
        {
            Persona[] resultado = new Persona[Alumnos.Length + 1];

            resultado[0] = InstructorCurso;
            for(int i = 1; i < resultado.Length; i++)
            {
                resultado[i] = Alumnos[i - 1];
            }

            return resultado;
        }

        public string ObtenerIdentificador()
        {
            return Identificador;
        }
    }
}
