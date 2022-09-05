using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double _cantidad;
        private static double _cotizadorDolar;

        static Euro()
        {
            _cotizadorDolar = 1 / 1.17;
        }
        public Euro(double cantidad)
        {
            GetSetCantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            SetCotizadorDolar = cotizacion;
        }

        /******************************************************/

        #region EXPLICIT IMPLICIT 

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetSetCantidad / _cotizadorDolar);
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e);
        }

        public static implicit operator Euro(double e)
        {
            return (Euro)e;
        }
        #endregion EXPLICIT IMPLICIT 

        /******************************************************/

        #region GETTER SETTER

        public static double GetCotizador
        {
            get { return _cotizadorDolar; }
           
        }
        public double SetCotizadorDolar
        {
            set { _cotizadorDolar = value; }
        }
        public double GetSetCantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        #endregion GETTER SETTER

        /******************************************************/

        #region SOBRECARGAS

        /*Operadores de Igualdad-DesIgualdad*/
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return e == (Euro)p;
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return  !(e == p);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetSetCantidad == e2.GetSetCantidad;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        /*Operadores de Matematicos*/
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetSetCantidad + ((Euro)d).GetSetCantidad);
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.GetSetCantidad - ((Euro)p).GetSetCantidad);
        }

        #endregion SOBRECARGAS

        /******************************************************/
    }
}
