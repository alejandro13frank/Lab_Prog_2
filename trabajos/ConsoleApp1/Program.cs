using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";
            int numero;
            int i;
            int j;
            if (int.TryParse(Console.ReadLine(),out numero))
            {
                for (i = 2; i<=numero; i++)
                {
                    for (j = 2; j<i ; j++)
                    {
                        if(i%j==0)
                        {
                            break;
                        }
                    }
                    if (i==j)
                    {
                        Console.WriteLine("{0} es primo", i);  
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
