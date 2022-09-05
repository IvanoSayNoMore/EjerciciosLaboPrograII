using System;
using ClassLibrary;
namespace Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I01 - Creo que necesito un préstamo";
            Cuenta cuenta = new Cuenta("Ivano", 10000);
            cuenta.Ingresar(20);
            cuenta.Retirar(300);

            Console.WriteLine($"{cuenta.Mostrar()}");
            Console.ReadKey();
        }
    }
}