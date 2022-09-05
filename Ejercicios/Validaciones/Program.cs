using System;
using System.Drawing;
using Valida = Ejercicios.Validador;
namespace Ejercicios;

    internal class Program
    {

        static void Main(string[] args)
         {
             string valorString;
             int valorNumero;
             int total = 0;
             float promedio;
             int min = 0;
             int max = 0;
             bool funciono;

             for (int i = 0; i < 3; i++)
             {

                 Console.WriteLine("Ingrese un número");
                 valorString = Console.ReadLine();
                 funciono = int.TryParse(valorString, out valorNumero);
                 // validado = Valida.Validar(valorNumero, -100, 100);
                 if (funciono)
                 {
                     while (!Validador.ValidarMayorMenor(valorNumero, -100, 100))
                     {
                         Console.WriteLine("Error en el numero ingresado. (fuera de rango), Reintente");
                         int.TryParse(Console.ReadLine(), out valorNumero);
                     }
                     if (i == 0)
                     {
                         min = valorNumero;
                         max = valorNumero;
                     }
                     else
                     {
                         if(valorNumero < min)
                         {
                             min = valorNumero;
                         }
                         if(valorNumero > max)
                         {
                             max = valorNumero;
                         }
                     }
                     total += valorNumero;                    
                 }
                 else
                 {
                     Console.WriteLine("Reintente");
                     i--;
                 }             

             }
             promedio = (float)total / 3;
             Console.WriteLine("Minimo {0} Maximo {1} Promedio {2}",min,max,promedio);
         }
     
    }