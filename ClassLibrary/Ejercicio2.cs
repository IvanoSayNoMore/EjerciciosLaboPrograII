using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Cuenta
    {
        public string titular;
        public int cantidad;

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string getTitutlar()
        {
            return this.titular;
        }
        public int getCantidad()
        {
            return this.cantidad;
        }
        public string Mostrar()
        {
            return $"El titular {this.getTitutlar()} La cantidad {this.getCantidad()}";
        }
        public int Ingresar(int ingreso)
        {
            if (ingreso > 0)
            {
                return this.cantidad += ingreso;
            }
            return this.getCantidad();
        }
        public int Retirar(int retiro)
        {
            if (retiro > 0)
            {
                return this.cantidad -= retiro;
            }
            return this.getCantidad();
        }
    }
}
