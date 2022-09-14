using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Cliente
    {
        private string _nombre;
        private int _numero;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Numero
        {
            get { return _numero; }
        }

        public  Cliente(int num)
        {
            _numero = num;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            Nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
