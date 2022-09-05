using System.Text;

namespace Sobrecarga
{
    public class SobrecargaConstructor
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("ivan", 123123, "asdas");
            Persona persona2 = new Persona("ivan", 123123);


        }
    }

    public class Persona
    {
        private int _dni;
        private string _nombre;
        private string _legajo;

        public Persona()
        {
            _dni = 0;
            _nombre = "";
        }

        public Persona(string nombre)
        {
            _nombre = nombre;   
        }

        public Persona(string nombre, int dni) : this(nombre)    
        {
            _dni = dni;

        }

        public Persona(string nombre,int dni,string legajo) : this(nombre,dni)
        {
            _legajo = legajo;   
        }


    }
}