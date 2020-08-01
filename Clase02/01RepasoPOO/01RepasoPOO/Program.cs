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
                    TipoDocumento="DU",
                    NumeroDocumento= "123123412"
                }
            };

            Console.WriteLine($"Instructor {instructor.ObtenerCodigoPersona()}");

            Persona unaPersona = instructor;
            Console.WriteLine(unaPersona.ObtenerCodigoPersona());

            Persona otraPersona = new Instructor();

            Console.ReadKey();
        }
    }
}
