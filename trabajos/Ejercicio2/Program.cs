using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";
            string valor;
            int numero;
            do
            {
                Console.Write("Ingrese un numero mayor a 0: ");
                valor=Console.ReadLine();
                if (int.TryParse(valor, out numero))
                {
                    if (numero<=0)
                    {
                        Console.WriteLine("ERROR. ¡Reingresar número!");
                    }
                }
            } while (numero<=0);
            Console.Write("el cuadrado del numero es: {0}\n",numero*numero);
            Console.Write("el cubo del numero es: {0}\n", numero*numero*numero);
            Console.ReadKey();
        }
    }
}
