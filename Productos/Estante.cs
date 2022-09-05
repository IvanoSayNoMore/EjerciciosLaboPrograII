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

        Producto[] GetProductos()
        {
            return _productos;
        }
        public static string MostrarEstante(Estante e)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estante ubicacion: {e._ubicacionEstante} \n");

            for (int i = 0; i < e._productos.Length; i++)
            {
                if (!Object.ReferenceEquals(e._productos[i], null))
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
            if(!(e is null && p is null))
            {
                for (int i = 0; i < e._productos.Length; i++)
                {
                    if (e._productos[i] == p)
                    {
                        return true;
                    }
                }
            }   
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
                return !(e == p);            
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)
            {
                for (int i = 0; i < e._productos.Length; i++)
                {
                    if (e._productos[i] is null)
                    {
                        e._productos[i] = p;
                        return true;

                    }
                }
            }

            return false;
        }

        #endregion SOBRECARGAS
    }
}
