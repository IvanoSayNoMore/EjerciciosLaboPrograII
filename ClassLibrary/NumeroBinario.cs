using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NumeroBinario
    {
        private string numero;
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string Numero
        {
            get { return this.numero; }
        }
        public double BinarioDecimal(string valorRecibido)
        {
            double resultado = 0;
            int cantidadChar = valorRecibido.Length;
            foreach(char caracter in valorRecibido)
            {
                cantidadChar--;
                if(caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadChar);
                }
            }
            return resultado;
        }

        #region ExplImpl

        public static explicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator NumeroDecimal(NumeroBinario numBinario)
        {
            return (NumeroDecimal)numBinario.BinarioDecimal(numBinario.Numero);
        }
        #endregion ExplImpl

        #region SOBRECARGAS
        public static bool operator ==(NumeroBinario nb,NumeroDecimal nd)
        {
            return nb.numero == ((NumeroBinario)nd).Numero;

        }

        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }

        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            return nd.DecimalBinaro(((NumeroDecimal)nb).Numero + nd.Numero);
        }
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            return nd.DecimalBinaro(((NumeroDecimal)nb).Numero - nd.Numero);
        }
        #endregion SOBRECARGAS



    }
}
