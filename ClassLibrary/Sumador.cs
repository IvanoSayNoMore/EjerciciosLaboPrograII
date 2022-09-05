using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Sumador
    {
        private long _sumadorCont;

        public long cantidadSumas
        {
            get { return _sumadorCont; }
            set { _sumadorCont = value; }
        }
        public Sumador(int ingresoo)
        {
            cantidadSumas = ingresoo;
        }

        public Sumador() : this(0){ }

        public long Sumar(long x,long y)
        {
            this._sumadorCont += 1;
            return x + y;
        }
        public string Sumar(string x,string y)
        {
            /*string concat = $"{x}{y}";
              string concat = String.Format("{0}{1}", x, y);
              string concat = String.Join(String.Empty, new string[] { x, y });
              string concat = String.Concat(x, y);
              string concatena = x + y;*/
            this._sumadorCont += 1;
            string concatena = new StringBuilder().Append(x).Append(y).ToString();
            return concatena;
        }


        public long Cantidad()
        {
            return this.cantidadSumas;
        }

        #region SOBRECARGAS


        public static bool operator |(Sumador s1,Sumador s2)
        {
            bool retorno = false;

            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true; 
            }

            return retorno;
        }

        public static int operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2;
        }

        #endregion

        #region EXPLICITAS

        public static explicit operator long(Sumador s1)
        {
            return s1.cantidadSumas;
        }


        #endregion
    }
}
