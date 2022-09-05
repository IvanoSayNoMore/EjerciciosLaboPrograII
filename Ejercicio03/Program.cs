using ClassLibrary;
using System;
namespace Ejercicio03    
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor;
            
            Estudiante estudiante = new Estudiante("Ivan", "Fabella", "asd23");
            estudiante.notaPrimerParcial = 8;
            estudiante.notaSegundoParcial = 8;
            estudiante.Mostrar();

            valor = estudiante.notaSegundoParcial;
            Console.WriteLine("---GET---"+valor);

            Estudiante estudiante1 = new Estudiante("Aldana", "Medina", "Legajo 14578");
            estudiante1.notaPrimerParcial = 7;
            estudiante1.notaSegundoParcial = 9;
            estudiante1.Mostrar();

            Estudiante estudiante2 = new Estudiante("Enano", "Peluza", "Legajo 1549");
            estudiante2.notaPrimerParcial = 3;
            estudiante2.notaSegundoParcial = 8;
            estudiante2.Mostrar();

        }
    }
}