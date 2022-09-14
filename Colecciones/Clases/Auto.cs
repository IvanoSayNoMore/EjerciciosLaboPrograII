using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones.Clases
{
    internal class Auto
    {
        public string modelo;
        public string marca;

        public Auto(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        public string Mostrar()
        {
            StringBuilder msjSB = new StringBuilder();
            //msjSB.AppendLine($"{nombre} {precio} {stock} ");
            msjSB.Append("Modelo");
            msjSB.Append("\t");
            msjSB.Append("Marca");
            msjSB.Append("\t");
            msjSB.Append("\n");
            msjSB.AppendLine($"{modelo}\t\t {marca}\t ");
            return msjSB.ToString();
        }



    }
}
