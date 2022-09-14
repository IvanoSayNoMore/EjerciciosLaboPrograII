using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones.Clases
{
    public class Datos
    {
        public static void Diccioniario()
        {
            Console.WriteLine("Diccionario");

            Auto autoUno = new Auto("Chevrolet","Corsa");
            Auto autoDos = new Auto("Ford", "Fiesta");
            Auto autoTres = new Auto("VW", "VENTO");
            Dictionary<string, Auto> autos = new Dictionary<string, Auto>();

            autos.Add("abc123",autoUno);
            autos.Add("abc467", autoDos);
            autos.Add("abc145", autoTres);

            foreach(KeyValuePair<string, Auto> item in autos)
            {
                Console.WriteLine("Clave " + item.Key + "Valor : " + item.Value.Mostrar());
            }
            bool pru;
            pru = autos.ContainsKey("abc123");//SI existe o no. Retorna booleano
            if(pru)
            {
                autos["abc123"].Mostrar();

            }
            else
            {
                Console.WriteLine("Key no exist");
            }


        }
    
        public static void Lista()
        {
            Auto autoUno = new Auto("Chevrolet", "Corsa");
            Auto autoDos = new Auto("Ford", "Fiesta");
            Auto autoTres = new Auto("VW", "VENTO");

            List<Auto> autos = new List<Auto>();

            autos.Add(autoUno);
            autos.Add(autoDos);
            autos.Add(autoTres);

            foreach(Auto auto  in autos)
            {
                Console.WriteLine(auto.Mostrar());
            }
            if(autos.Remove(autoUno))
            {

            }

        }
    
    }
}
