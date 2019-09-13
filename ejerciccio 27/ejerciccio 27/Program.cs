using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciccio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeroRandom = new Random();
            int i;
            List<int> listaNumero = new List<int>();
            Queue<int> colaNumero = new Queue<int>();
            Stack<int> pilaNumero = new Stack<int>();
            for (i=0;i<20;i++)
            {
                listaNumero.Add(numeroRandom.Next(-100, 100));
            }

            foreach (int numero in listaNumero)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.WriteLine("--------Ordenados-----------");

            listaNumero.Sort();
            foreach (int numero in listaNumero)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
            Console.WriteLine("--------positivos-----------");
            foreach (int numero in listaNumero)
            {
                if (numero<0)
                {
                    Console.WriteLine("encole negativo {0}", numero);
                    colaNumero.Enqueue(numero);
                }
                else if (numero!=0)
                {
                    Console.WriteLine("apile pisitivo {0}", numero);
                    pilaNumero.Push(numero);
                }
            }
            Console.WriteLine("negativos ascendentes------------");
            while (colaNumero.Count > 0)
            {
                Console.WriteLine(colaNumero.Dequeue());
            }
            Console.WriteLine("positivos descendentes------------");
            while (pilaNumero.Count > 0)
            {
                Console.WriteLine(pilaNumero.Pop());
            }
            Console.ReadKey();


        }
    }
}
