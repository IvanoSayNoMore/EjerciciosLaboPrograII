namespace EjercPowMath
 

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar un número y mostrar el cuadrado y el cubo del mismo.
             * Se debe validar que el número sea mayor que cero, caso contrario,
             * mostrar el mensaje: "ERROR. ¡Reingresar número!".*/
            int numA = 10;
            double numb;
            numb = Math.Pow(numA,5);
            Console.WriteLine(numb);
        }
    }
}