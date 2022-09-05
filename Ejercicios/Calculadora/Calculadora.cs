using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Calculadora
{
    internal class Calculadora
    {
       
        static void Main(string[] args)
        {
            int numA;
            int numB;
            char operador;
            bool validaDistintoCero;
            int seguir;
            string valorString;
            bool funciono;           

            do
            {
                numA = Validador.validaIngresoNumero();
                numB = Validador.validaIngresoNumero();
                operador = Validador.validaOperadorMatematico();
                if (operador != 'E')
                {
                    if (operador != '/')
                    {
                        Calculos.calculo(numA, numB, operador);
                    }
                    else
                    {
                        validaDistintoCero = validaMayorACero(numB);
                        if (validaDistintoCero)
                        {
                            Calculos.calculo(numA, numB, operador);
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por Cero.");
                        }
                    }
                }
                Console.WriteLine("Si desa continuar, precione 0." +
                    " Para salir, oprima cualquier otra tecla? ");
                valorString = Console.ReadLine();
                funciono = int.TryParse(valorString, out seguir);

            } while (seguir == 0);

        }
        private static bool validaMayorACero(int num)
        {
            if (num != 0)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
    }
}
