using static Clase2Progra2908.ClassMoto;

namespace Clase2Progra2908
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Moto moto = new Moto("CBR", "Honda", "Patente765", 250);

            moto.TocarBocina();

            Console.WriteLine("Tanque vacio {0}", moto.combustible);

            Moto.LlenarTanque(moto);

            Console.WriteLine("Tanque full {0} ", moto.combustible);

            ClassPersona persona = new ClassPersona(37557925, "Ivano Fabella");

            Console.WriteLine("Persona {0} - {1}", persona.getName(), persona.getDni());
        }
    }
}
