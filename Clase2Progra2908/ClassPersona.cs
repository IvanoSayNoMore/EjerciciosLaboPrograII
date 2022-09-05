using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2Progra2908
{
    public class ClassPersona
    {
        private int _dni;
        private string _name; 

        public ClassPersona(int dni, string name)
        {
            setDni(dni);
            setNombre(name);
        }
        public int getDni()
        {
            return _dni;
        }
        public String getName()
        {
            return _name;
        }

        public void setDni(int dni)
        {
            _dni=dni;
        }
        public void setNombre(String name)
        {
            _name = name;
        }
    }
}
