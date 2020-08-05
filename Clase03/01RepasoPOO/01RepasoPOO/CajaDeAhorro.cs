using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RepasoPOO
{
    class CajaDeAhorro
    {
        private string idCuenta;

        public string GetIdCuenta()
        {
            return idCuenta;
        }

        public void SetIdCuenta(string nuevoIdCuenta)
        {
            idCuenta = nuevoIdCuenta;
        }

        //Property autoimplementada
        public int Sucursal { get; set; }

        private int ejecutivo;

        public int Ejecutivo
        {
            get
            {
                return ejecutivo;
            }
            set
            {
                if (value <= 0)
                {
                    ejecutivo = 37;
                }
                else
                {
                    ejecutivo = value;
                }
            }
        }

        private decimal saldo;

        public void Depositar(decimal cantidad)
        {
            //saldo = saldo + cantidad;
            saldo += cantidad;
        }

        public bool Extraer(decimal cantidad)
        {
            bool resultado = false;

            if(cantidad <= saldo)
            {
                //saldo = saldo - cantidad;
                saldo -= cantidad;
                resultado = true;
            }

            return resultado;
        }
    }
}
