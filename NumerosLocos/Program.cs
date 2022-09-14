using ClassLibrary;
namespace NumerosLocos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] arrayNum = new int[20];

            List<int> numLocos = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                numLocos.Add(rand.Next(-100, 100));
            }
            Console.WriteLine("Lista ingresada");
            arrayNum = numLocos.ToArray();

            foreach(int numSinOrdernar in numLocos)
            {
                Console.WriteLine(numSinOrdernar);
            }

            numLocos.Sort();

            foreach (int ordenados in numLocos)
            {
                Console.WriteLine(ordenados);
            }
 
            //numLocos.OrderByDescending(x => x);

            Console.WriteLine("Dado Vuelta");
            if (numLocos.Count() > 0)
            {
                numLocos.Reverse();
            }
            foreach (int ordenadosReverse in numLocos)
            {
                Console.WriteLine(ordenadosReverse);
            }

            Console.WriteLine("Dado Vuelta");
        }
    }
}