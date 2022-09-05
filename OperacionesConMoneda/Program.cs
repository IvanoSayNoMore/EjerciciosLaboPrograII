using Billetes;
namespace OperacionesConMoneda
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar   = new Dolar(100);
            Pesos peso    = new Pesos(500,150);  
            Euro  euro    = new Euro(300);
            

            Pesos pesos2  = 10;
            Pesos pesos3  = new Pesos(10);

            Euro  nwEuro  = euro + dolar;
            Pesos nwPesos = peso + euro;
            Dolar nwDolar = dolar + euro;
            Pesos nwPesosD = peso + dolar;
            Pesos newPesosPesos = peso + pesos2;

            Console.WriteLine("Euro + Dólar a Euro : {0}",
                nwEuro.GetSetCantidad);

            Console.WriteLine("Dolar + Euro a Dolar: {0}",
               nwDolar.GetCantidad);

            Console.WriteLine("Pesos + Pesos: {0}",
               newPesosPesos.GetCantidad);
        }
    }
}