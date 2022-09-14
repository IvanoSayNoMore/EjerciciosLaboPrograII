using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NumerosLocos
{
    public class Ejercicio02
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Queue<int> ColaPositivos = new Queue<int>();
            Stack<int> pilaPositivo = new Stack<int>();
            Stack<int> pilaNegativo = new Stack<int>();
            Queue<int> ColaNegativo = new Queue<int>();

            //Queue es la cola de supermercado y Stack seria una pila de platos PPT de la clase 4
            //stack LIFO  / queue FIFO

            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(rand.Next(-100, 100));
            }
            foreach (int numSinOrdernar in lista)
            {
                Console.WriteLine(numSinOrdernar);
            }
            lista.Sort();
            foreach (int num in lista)
            {
                if (num > 0)
                {
                    Console.WriteLine(num);
                    ColaPositivos.Enqueue(num);
                }
                else
                {
                    pilaNegativo.Push(num);
                }
            }

            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i] > 0)
                {
                    pilaPositivo.Push(lista[i]);//agrego positivo a la pila de positivos
                }
                else if (i != 0)//evito el cero
                {
                    Console.WriteLine(lista[i]);
                    ColaNegativo.Enqueue(lista[i]);//agrego negativos a la lista de negativos
                }
            }
            Console.WriteLine(" Cola Positivos");
            foreach (int i in ColaPositivos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Pila Positivos");
            foreach (int i in pilaPositivo)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Cola Negativos");
            foreach (int i in ColaNegativo)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Pila Negativos");
            foreach (int i in pilaNegativo)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static int OrdenDescendente(int a, int b)
        {
            return b - a;
        }
     
    }
}


   
