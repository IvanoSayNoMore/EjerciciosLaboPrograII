using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones.Clases
{
   
    public class Persona
    {
        private string _nombre;
        private string apellido;

        public string[] dias = { "lunes", "martes", "miercoles" };
        public string this[int index]
        {
            get { return dias[index]; }
            set { dias[index] = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
            }
        }
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;    
        }
    }
}
