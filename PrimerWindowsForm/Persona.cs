using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerWindowsForm
{
    public class Persona
    {
        public string name;
        public string lastname;

        public Persona(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{lastname} ");
            sb.Append($"{name}");

            return sb.ToString();

        }
    }
}
