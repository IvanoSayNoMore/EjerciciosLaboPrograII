using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double _cantidad;
        private static double _cotizadorDolar;

        static Pesos()
        {
            _cotizadorDolar = 1/102.65;
        }
        public Pesos(double cantidad)
        {
            SetCantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            SetCotizadorDolar = cotizacion;
        }
        /******************************************************/

        #region EXPLICIT IMPLICIT 

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p._cantidad / _cotizadorDolar);
        }

        public static explicit operator Euro(Pesos p)
        {
            return  (Euro)((Dolar)p);
        }

        public static implicit operator Pesos(double p)
        {
            return  new Pesos(p);
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
        public static bool operator ==(Pesos p, Euro e)
        {
            return p == e;
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == (Pesos)e);
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == d;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == (Pesos)d);
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1 == p2;
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad != p2._cantidad;
        }

        /*Operadores de Matematicos*/
        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad + ((Pesos)e).GetCantidad);
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad - ((Pesos)d).GetCantidad);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad+((Pesos)d).GetCantidad);
        }

        public static Pesos operator +(Pesos p1, Pesos p2)
        {
            return new Pesos(p1.GetCantidad + p2.GetCantidad);
        }
        #endregion SOBRECARGAS

        /******************************************************/
    }
}
