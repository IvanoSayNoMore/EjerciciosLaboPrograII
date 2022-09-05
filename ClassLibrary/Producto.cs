using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
   public class Producto
    {
        private string _nombre;
        private int _precio;
        private int _stock;
        private int _ID;

        public string nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }

        public int precio
        {
            set { _precio = value; }
            get { return _precio; }
        }

        public int stock
        {
            set { _stock = value; }
            get { return _stock; }
        }

        public int id
        {
            get { return _ID; }
        }
        public Producto(int precio)
        {
            _precio = precio;
        }

        public Producto(int precio,string nombre) : this(precio)
        {
            _nombre = nombre;
        }

        public Producto(int precio, string nombre, int stock) : this(precio,nombre)
        {
            _stock = stock;    
        }

        public Producto(int precio, string nombre, int stock, int id) : this(precio,nombre,stock)
        {
            _ID = id;
        }
        
        public void Mostrar()
        {
            StringBuilder msjSB = new StringBuilder();
            //msjSB.AppendLine($"{nombre} {precio} {stock} ");
            msjSB.Append("Producto");
            msjSB.Append("\t");
            msjSB.Append("Precio");
            msjSB.Append("\t");
            msjSB.Append("Stock");
            msjSB.Append("\t");
            msjSB.Append("\n");
            msjSB.AppendLine($"{nombre}\t\t {precio}\t {stock} ");
            Console.WriteLine(msjSB.ToString());
            
        }
        public void Mostrar(ConsoleColor backColor)
        {
            Console.BackgroundColor = backColor;//Todo donde escribe 
            Mostrar();
        }

        public void Mostrar(ConsoleColor backColor, ConsoleColor letra)
        {
            Console.ForegroundColor = letra;
            Mostrar(backColor);
        }

        #region SOBRECARGAS

        public static explicit operator int(Producto p1)
        {
            return p1.id;
        }

        public static int operator +(Producto prod1,Producto prod2)
        {
            return (prod1.stock * prod1.precio) + (prod2.stock * prod2.precio);
        }

        public static bool operator ==(Producto p1, int id)
        {
            return p1.id == id;
        }

        public static bool operator !=(Producto p1, int id)
        {
            return !(p1 == id);
        }

        public static int operator -(Producto prod1, int outStock)
        {
            return prod1.stock - outStock;
        }

        public static implicit operator string(Producto p1)
        {
            return p1.nombre;
        }

        #endregion

    }
}
