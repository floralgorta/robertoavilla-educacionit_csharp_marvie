using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = 10;

            long miNumeroSuperLargo = 123124123124123123L;
            miNumeroSuperLargo = 1000;

            Console.WriteLine(numero);
            Console.WriteLine(miNumeroSuperLargo);

            double miDecimal = 10.6;
            float miFloat = 10.6F;
            decimal miValorPreciso = 10.5M;

            string miVariableString = "Hola Mundo";
            Console.WriteLine(miVariableString);

            char unCaracter = 'a';

            var miVariableVar = 10;
            var miOtraVariableVar = "Hola mundo";

            //No se puede porque miOtraVariableVar es string
            //miOtraVariableVar = 10;

            var miVariableArray = new[] { 0, 1, 2 };

            // Concatenacion con strings
            string nombre = "Andres";
            Console.WriteLine("Hola {0},{1}", nombre, miOtraVariableVar);

            string otraForma = "Hola " + nombre + "," + miOtraVariableVar;

            //string interpolation
            string otraFormaMas = $"Hola {nombre},{miOtraVariableVar}";

            Console.ReadKey();
        }
    }
}
