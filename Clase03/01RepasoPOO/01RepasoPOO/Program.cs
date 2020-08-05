using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RepasoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase2();

            Curso curso = new Curso();
            Instructor instructor = new Instructor()
            {
                nombre = "Andres",
                apellido = "Villa",
                Documento = new Documento()
                {
                    TipoDocumento = "DU",
                    NumeroDocumento = "1234123"
                }
            };
            curso.InstructorCurso = instructor;

            for (int i = 0; i < 30; i++)
            {
                Alumno alumno = new Alumno()
                {
                    apellido = $"apellido alumno {i}",
                    nombre = $"nombre alumno {i}",
                    Documento = new Documento()
                    {
                        TipoDocumento = "DU",
                        NumeroDocumento = $"{i}"
                    }
                };
                curso.Alumnos[i] = alumno;
            }

            Persona[] arrayDePersonas = curso.ObtenerParticipantes();

            for (int i = 0; i < arrayDePersonas.Length; i++)
            {
                Console.WriteLine(arrayDePersonas[i].ObtenerCodigoPersona());
            }

            IIdentificable miCurso = curso;

            Console.ReadKey();
        }

        private static void Clase2()
        {
            Persona miPersona = new Persona();
            miPersona.apellido = "Villa";
            miPersona.nombre = "Andres";
            Documento unDocumentoPersona = new Documento()
            {
                TipoDocumento = "DU",
                NumeroDocumento = "1231243123"
            };
            miPersona.Documento = unDocumentoPersona;

            string desc = miPersona.ObtenerCodigoPersona();
            Console.WriteLine(desc);

            // Inicializador de objetos
            Documento otroDocumentoPersona = new Documento()
            {
                TipoDocumento = "DU",
                NumeroDocumento = "12341"
            };
            Persona miOtraPersona = new Persona()
            {
                apellido = "Gomez",
                Documento = otroDocumentoPersona,
                nombre = "Carlos"
            };

            CajaDeAhorro miCajaDeAhoro = new CajaDeAhorro();
            //No puedo poner el valor porque el saldo es privado
            //miCajaDeAhoro.saldo = 120012300;
            miCajaDeAhoro.Sucursal = 10;
            miCajaDeAhoro.Ejecutivo = -7;
            miCajaDeAhoro.Depositar(1999);

            var retiro = miCajaDeAhoro.Extraer(1000000);
            Console.WriteLine($"Pudo extraer? {retiro}");


            Alumno unAlumno = new Alumno()
            {
                apellido = "AlumnoApellido",
                nombre = "NombreAlumno",
                Documento = new Documento()
                {
                    NumeroDocumento = "123123",
                    TipoDocumento = "PASAPORTE"
                },
                CuotaAlDia = true
            };

            Console.WriteLine($"Alumno {unAlumno.ObtenerCodigoPersona()}");

            Instructor instructor = new Instructor()
            {
                apellido = "Villa",
                nombre = "Andres",
                CantidadCursosAsignados = 3,
                Documento = new Documento()
                {
                    TipoDocumento = "DU",
                    NumeroDocumento = "123123412"
                }
            };

            Console.WriteLine($"Instructor {instructor.ObtenerCodigoPersona()}");

            Persona unaPersona = instructor;
            Console.WriteLine(unaPersona.ObtenerCodigoPersona());

            Persona otraPersona = new Instructor();
        }
    }
}
