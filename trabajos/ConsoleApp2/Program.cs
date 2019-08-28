using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";
            int numero;
            int i;
            int j;
            int contador = 0;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                for (i = 1; i <= numero; i++)
                {
                    contador = 0;
                    for (j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            contador += j;
                        }
                    }
                    if (i == contador)
                    {
                        Console.WriteLine("{0} el perfecto", i);
                        
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
