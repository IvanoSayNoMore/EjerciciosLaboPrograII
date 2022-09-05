using ClassLibrary;
namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sumador sumaString = new Sumador(2);
            Sumador sumaNumero = new Sumador(2);

            Console.WriteLine($"Suma de 1eros obj {sumaNumero + sumaString}");
            Console.WriteLine($"Suma numeros {sumaNumero.Sumar(5, 7)} LlamadaCanitdadSumas: {sumaNumero.cantidadSumas}");
            Console.WriteLine($"Suma de cantidades {sumaNumero + sumaString}");
            Console.WriteLine($"Suma String {sumaString.Sumar("Ivano","Fabellon")} LlamadaCanitdadSumas: {sumaString.cantidadSumas}");
            Console.WriteLine($"Suma de cantidades {sumaNumero + sumaString}");
            
            if(sumaString | sumaNumero)
            {
                Console.WriteLine("Igual cantidad de sumas");  
            }
            else
            {
                Console.WriteLine("Distintas cantidad de sumas ");
            }
            Console.WriteLine($"Suma de obj{sumaNumero + sumaString}");

        }
    }
}