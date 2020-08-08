using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Personajes
{
    public class Tablero
    {
        public int DimensionX { get; set; }

        public int DimensionY { get; set; }

        //public Personaje[] Poblacion { get; set; } = new Personaje[0];

        public List<Personaje> Poblacion { get; set; } = new List<Personaje>();

        public EstadoJuego Estado { get; set; }

        public Tablero()
        {
            Estado = EstadoJuego.Iniciado;
        }

        public void AgregarPersonaje(Personaje personaje)
        {
            /*Personaje[] aux = new Personaje[Poblacion.Length + 1];
            
            for(int i = 0; i < Poblacion.Length; i++)
            {
                aux[i] = Poblacion[i];
            }

            aux[aux.Length-1] = personaje;

            Poblacion = aux;*/
            Poblacion.Add(personaje);
        }

        public void AgregarPersonaje(List<Personaje> personajes)
        {
            Poblacion.AddRange(personajes);
        }

        public void RecorrerPersonajesConBucleFor()
        {
            for(int i = 0; i < Poblacion.Count; i++)
            {
                Personaje elPersonaje = Poblacion[i];
                elPersonaje = Poblacion.ElementAt(i);
            }
        }

        public override string ToString()
        {
            string resultado = $"Tablero {DimensionX}x{DimensionY}\r\n"; // \r\n sirve para poner un enter en la consola
            resultado += $"Poblacion:\r\n";
            foreach(var item in Poblacion)
            {
                resultado += $"{item.Nombre} PosX: {item.PosicionX}, PosY: {item.PosicionY}\r\n";
            }
            resultado += "------------------\r\n";
            return resultado;
        }

        public void MoverTodo()
        {
            foreach (var per in Poblacion)
            {
                per.Mover();
                if (per.PosicionX > DimensionX)
                {
                    per.PosicionX = DimensionX;
                }

                if(per.PosicionY > DimensionY)
                {
                    per.PosicionY = DimensionY;
                }
            }
        }

        public void Reiniciar()
        {
            Poblacion.Clear();
            Estado = EstadoJuego.Iniciado;
        }

        public void Finalizar()
        {
            Estado = EstadoJuego.Finalizado;
        }
    }
}
