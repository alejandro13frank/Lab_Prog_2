using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;
            char c='c';
            do
            {
                Console.Write("Ingrese numero a sumar: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    suma += numero;
                }
                Console.Write("desea seguir ingresando?S/N: ");
                char.TryParse(Console.ReadLine(),out c);
            } while (ValidarRespuesta.ValidarS_N(c));
            Console.WriteLine("la suma total es: {0}", suma);
            Console.ReadKey();
        }
    }
}
