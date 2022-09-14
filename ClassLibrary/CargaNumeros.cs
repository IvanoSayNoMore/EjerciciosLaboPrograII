using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CargaNumeros
    {
        private int _numeros;
        private static Random _random;
        public CargaNumeros(int numero)
        {
            _numeros = numero;
        }

        static CargaNumeros()
        {
            _random = new Random();
        }
    }
}
