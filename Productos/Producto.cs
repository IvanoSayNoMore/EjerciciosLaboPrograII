using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float  _precio;
        public Producto(string marca)
        {
            this._marca = marca;
        }
        public Producto(string marca, string codigoDeBarra) : this(marca)
        {
            this._codigoDeBarra = codigoDeBarra;
        }
        public Producto(string marca, string codigoDeBarra, float precio) : this(marca, codigoDeBarra)
        {           
            this._precio         = precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return String.Format("MARCA {0} CODIGO {1} PRECIO {2} ", p._marca, (string)p, p._precio);
        }

        /*************************************************************/
        #region GetterSetter

        public string GetMarca
        {
            get { return this._marca; }
        }

        public float GetPrecio
        {
            get { return this._precio; }
        }
        #endregion GetterSetter

        /*************************************************************/

        #region SOBRECARGAS Operadores

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return (p1.GetMarca == p2.GetMarca && p1._codigoDeBarra == p2._codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            
               return !(p1.GetMarca == p2.GetMarca);   
          
        } 
        public static bool operator ==(Producto p1, string marca)
        {
            if (!(p1 is null || marca is null))
            {
                if (p1.GetMarca == marca)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Producto p1, string marca)
        {            
                if (p1.GetMarca == marca)
                {
                    return true;
                }            
            return false;
        }

        #endregion SOBRECARGAS Operadores

        /*************************************************************/

        #region ImplicitasExplicitas

        public static implicit operator string(Producto p1)
        {
            if(!(p1 is null))
            {
                return p1._codigoDeBarra;
            }
            return "alg";
        }

        #endregion ImplicitasExplicitas

        /*************************************************************/

    }
}
