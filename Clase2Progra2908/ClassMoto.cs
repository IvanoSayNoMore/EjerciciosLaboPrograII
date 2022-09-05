using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2Progra2908
{
    internal class ClassMoto
    {
        public class Moto
        {
            public string marca;
            public string modelo;
            public string patente;
            public int cilindrada;
            public int combustible;
            static private int cantidadNafta = 100;

            public Moto(string marca, string modelo, string patente, int cilindrada)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.patente = patente;
                this.cilindrada = cilindrada;
                this.combustible = 0;
            }
         /*   public Moto(string marca, string modelo, string patente, int cilindrada, int combustible) 
            {
                this.marca = marca;
                this.modelo = modelo;
                this.patente = patente;
                this.cilindrada = cilindrada;
                this.combustible = 0;
            }*/
    
            public void TocarBocina()
            {
                Console.WriteLine("Beap beap {0}", this.patente);
            }
            static public void LlenarTanque(Moto moto)
            {
                moto.combustible = cantidadNafta;
            }
   
        }
    }
}
