using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Estante
    {

        private Producto[] _productos;
        private int _ubicacionEstante;

        public Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }
        public Estante(int capacidad,int ubicacion) : this(capacidad)
        {
           _ubicacionEstante = ubicacion;
        }
        private Producto[] GetProductos
        {
            get { return _productos; }
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estante ubicacion: {e._ubicacionEstante} \n");

            for (int i = 0; i < e.GetProductos.Length; i++)
            {
                if (!Object.ReferenceEquals(e.GetProductos[i], null))
                {
                    sb.AppendLine(Producto.MostrarProducto(e._productos[i]));
                    sb.AppendLine("----------------------");
                }
            }
            return sb.ToString();
        }

        #region SOBRECARGAS

        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            if (!(e is null && p is null))
            {                 
                for (int i = 0; i < e.GetProductos.Length; i++)
                {
                    if (e.GetProductos[i] == p)
                    {
                        retorno = true;
                        break;
                    }
                }
            }   
            return retorno;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);            
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false ;
            if (e != p)
            {
                for (int i = 0; i < e.GetProductos.Length; i++)
                {
                    if (e.GetProductos[i] is null)
                    {
                        e.GetProductos[i] = p;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        #endregion SOBRECARGAS
    }
}
