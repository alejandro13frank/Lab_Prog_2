using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(1,4);
            Punto punto3 = new Punto(5,1);
            Rectangulo rectangulo1 = new Rectangulo(punto1,punto3);
            Console.WriteLine("Area: {0}", rectangulo1.Area());
            Console.WriteLine("Perimetro: {0}", rectangulo1.Perimetro());
            Console.ReadKey();
        }
    }
}
