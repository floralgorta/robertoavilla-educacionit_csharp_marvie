using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EstructurasDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 30;
            int numeroDos = 50;
            int numeroTres = 80;

            /*
             * CONDICIONALES
             * == igual
             * != distinto
             * >  mayor
             * <  menor
             * >= mayor o igual
             * <= menor o igual
             */

            /*
             * OPERADORES LOGICOS
             * && "y" logico
             * || "o" logico
             * !  "no" logico
             */

            Console.Write("Ingresá un valor: ");
            string valor = Console.ReadLine();

            numeroUno = int.Parse(valor); // Pueden usar el TryParse

            if (numeroUno != 10)
            {
                Console.WriteLine("El numero es distinto de 10");
            }
            else
            {
                Console.WriteLine("El numero es igual a 10");
            }

            if (numeroUno != 10 && numeroDos != 30)
            {
                Console.WriteLine("Se dan las condiciones al mismo tiempo");
            }
            else if (numeroDos == 50)
            {
                if (numeroTres == 100)
                {

                }
            }
            else
            {

            }

            // El switch se usa cuando tengo que comparar una variable con n posibilidades

            int edad = 30;

            if (edad == 0)
            {

            }
            else if (edad == 1)
            {
            }
            else if (edad == 2)
            {

            }

            switch (edad)
            {
                case 0:
                //break; //si no tengo este break va a entrar al mismo bloque si es 0 o 1
                case 1:
                    Console.WriteLine("Hola");
                    break;
                case 2:
                    break;
                default: //Equivalente al ultimo else
                    break;
            }


            int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine($"Hola, el contador while es {contador}");
                contador++;
            }

            contador = 0;
            do
            {
                Console.WriteLine($"Hola, el contador do while es {contador}");
                contador++;
            } while (contador < 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hola, el contador for es {i}");
            }

            Console.ReadKey();
        }
    }
}
