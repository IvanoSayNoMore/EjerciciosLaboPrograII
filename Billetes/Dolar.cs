using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double _cantidad;
        private static double _cotizadorDolar;


        static Dolar()
        {
            _cotizadorDolar = 1;
        }

        public Dolar(double cantidad)
        {
            SetCantidad = cantidad;
        }

        /******************************************************/

        #region EXPLICIT IMPLICIT 


        public static explicit operator Euro(Dolar d)
        {
            return new Euro(Euro.GetCotizador * d.GetCantidad);
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(Pesos.GetCotizador * d.GetCantidad);
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        #endregion EXPLICIT IMPLICIT 
        /******************************************************/

        #region GETTER SETTER
        public double GetCantidad
        {
            get { return _cantidad; }
        }

        public double SetCantidad
        {
            set { _cantidad = value; }
        }

        #endregion GETTER SETTER

        /******************************************************/


        #region SOBRECARGAS

        /*Operadores de Igualdad-DesIgualdad*/
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.GetCantidad == (Dolar)e;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Pesos p)
        {

            return d.GetCantidad == (Dolar)p;
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad == d2._cantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        /*Operadores de Matematicos*/
        public static Dolar operator +(Dolar d,Euro e)
        {
            return new Dolar(d.GetCantidad + ((Dolar)e).GetCantidad);
        }         
        public static Dolar operator -(Dolar d,Euro e)
        {
            return new Dolar(d.GetCantidad - ((Dolar)e).GetCantidad);
        }

        #endregion SOBRECARGAS

        /******************************************************/
    }
}
