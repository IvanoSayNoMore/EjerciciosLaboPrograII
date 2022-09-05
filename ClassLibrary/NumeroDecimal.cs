using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NumeroDecimal
    {
        private double numero;
        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero
        {
            get { return this.numero; } 
        }

        public string DecimalBinaro(double numero)
        {
            string valorBinario = string.Empty;
            int resulDiv = (int)numero;
            int restoDiv=0;
            if(restoDiv>=0)
            {
                do
                {
                    restoDiv = resulDiv % 2;
                    resulDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario;
                }while(restoDiv>0); 
            }
            return valorBinario;
        }

        #region SOBRECARGAS
        public static explicit operator NumeroDecimal (double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)numeroDecimal.DecimalBinaro(numeroDecimal.Numero);
        }

        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        { 
            return nd.numero == ((NumeroDecimal)nb).Numero;
        }
        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nd == nb); 
        }



        #endregion SOBRACARGAS
    }
}
