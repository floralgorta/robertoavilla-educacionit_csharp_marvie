using Conversiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>() { "Andres", "Damian", "Carla", "Macarena" };
            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }
            nombres.Remove("Damian");
            Console.WriteLine("-----------------");
            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }

            List<Persona> personas = new List<Persona>();
            for(int i=0; i < 10; i++)
            {
                Persona persona = new Persona()
                {
                    DNI = i
                };
                personas.Add(persona);
            }

            Persona personaAQuitar = null;
            //No lo quita porque no es el mismo objeto. Es otro con el mismo dni
            //personas.Remove(personaAQuitar);

            /*foreach (var persona in personas)
            {
                if (persona.DNI == 15)
                {
                    personaAQuitar = persona;
                }
            }

            if (personaAQuitar != null)
            {
                personas.Remove(personaAQuitar);
            }        */

            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].DNI == 5)
                {
                    personas.Remove(personas[i]);
                    break;
                }
            }

            Console.WriteLine("-----------");
            foreach (var persona in personas)
            {
                Console.WriteLine($"DNI {persona.DNI}");
            }

            Console.WriteLine(ConversionesIVA.AgregarIva(100));

            Console.ReadKey();
        }
    }
}
