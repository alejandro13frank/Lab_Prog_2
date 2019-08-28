using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";
            int numero;
            int contadorDerecha = 0;
            int contadorIzquierda = 0;
            int i, j;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                while (numero > 1)
                { 
                    for (i = numero; i > 0; i--)
                    {
                        contadorDerecha = 0;
                        contadorIzquierda = 0;
                        for (j = i + 1; j <= numero; j++)
                        {
                            contadorDerecha += j;
                        }
                        for (j = i - 1; j >= 1; j--)
                        {
                            contadorIzquierda += j;
                        }
                        if (contadorIzquierda == contadorDerecha)
                        {
                            Console.WriteLine("el numero centrico es {0}", i);
                            break;
                        }
                    }
                    numero--;
                }
            }
            else
            {
                Console.WriteLine("EERRRORORO, chau");
            }
            Console.ReadKey();
        }
    }
}
