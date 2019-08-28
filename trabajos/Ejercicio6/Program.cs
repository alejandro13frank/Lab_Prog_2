using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 6";
            int anioInicio, anioFin;
            int i;
            if (int.TryParse(Console.ReadLine(), out anioInicio) && int.TryParse(Console.ReadLine(), out anioFin))
            {
                for (i=anioInicio;i<=anioFin;i++)
                {
                    if (i%4==0 || (i%100!=0 && i%400==0))
                    {
                        Console.WriteLine("Es biciesto {0}", i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
