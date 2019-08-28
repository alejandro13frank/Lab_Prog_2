using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            Console.Write("Ingrese un numero entre -100 y 100: ");
            if (int.TryParse(Console.ReadLine(), out anioInicio))
            {
                if (Validacion.Validar(anioInicio,-100,100))
                {
                    Console.WriteLine("GENIIIIOOO");
                }
                else
                {
                    Console.WriteLine("BOOOOOOOOOBOOOOO");
                }
            }

            Console.ReadKey();
        }
    }
}
