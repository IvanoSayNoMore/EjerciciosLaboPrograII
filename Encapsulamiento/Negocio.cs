using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    internal class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string _nombre;

        private Negocio()
        {            
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto);
        }

  
    }
}
