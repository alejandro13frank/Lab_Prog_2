using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boliAzul = new Boligrafo(ConsoleColor.Blue,8);
            Boligrafo boliRojo = new Boligrafo(ConsoleColor.Red,50);
            string dibujo="";
            boliAzul.Pintar(10, out dibujo);
            Console.ForegroundColor = boliAzul.GetColor();
            Console.WriteLine(dibujo);
            Console.ReadKey();

        }
    }
}
