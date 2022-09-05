using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Validador
    {
        public static bool ValidarMayorMenor(int valor, int min, int max)
        {
            bool validador = true;

            if(valor < min || valor > max)
            {
                validador = false;
            }
            return validador;
        }
        public static int validaIngresoNumero()
        {
            int numero;
            string valorString;
            bool funciono;
            do
            {
                Console.WriteLine("Ingrese un número");
                valorString = Console.ReadLine();
                funciono = int.TryParse(valorString, out numero);
                if(!funciono)
                {
                    Console.WriteLine("Ingrese solo numeros");
                }

            } while (!funciono);

            return numero;

        }

        public static char validaOperadorMatematico()
        {
            char operador;
            bool funciono;
            int intentos = 3;
            do
            {
                Console.WriteLine("Ingrese operador");
                operador = Console.ReadLine()[0];

                if(operador != '+' && operador != '-'
                    && operador != '*' && operador != '/')
                {
                    if (intentos == 0)
                    {
                        Console.WriteLine("No quedan intentos");
                        operador = 'E';
                        break;
                    }
                    
                    Console.WriteLine("Error al ingresar" +
                        " operador. quedan {0} intentos",intentos);
                    intentos--;

                    funciono = false;  
                }
                else
                {
                    funciono = true; 
                }

            } while (!funciono);
            
            return operador;
        }

        
    }
}
