using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Calculadora
{
    public static class Calculos
    {
        public static float calculo(int numA, int numB, char operador)
        {
            int resultado;
             switch(operador)
                {
                case '+':
                    resultado = suma(numA, numB);
                    Console.WriteLine(resultado);
                    break;
                case '-':
                    resultado = resta(numA, numB);
                    Console.WriteLine(resultado);
                    break;
                case '*':
                    resultado = mult(numA, numB);
                    Console.WriteLine(resultado);
                    break;
                case '/':
                    resultado = div(numA, numB);
                    Console.WriteLine(resultado);
                    break;

            }
            return 0;
        }
        public static int suma(int numA, int numB)
        {
            return numA + numB;
        }

        public static int resta(int numA, int numB)
        {
            return numA - numB;
        }

        public static int mult(int numA, int numB)
        {
            return numA * numB;
        }

        public static int div(int numA, int numB)
        {
            return numA / numB;
        }
    }



}
