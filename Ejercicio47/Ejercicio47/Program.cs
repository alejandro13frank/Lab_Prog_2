using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneFutbol = new Torneo<EquipoFutbol>("AFA");
            Torneo<EquipoBasket> torneBasket = new Torneo<EquipoBasket>("FEBAMBA");

            EquipoBasket equiB1 = new EquipoBasket("country", DateTime.Today);
            EquipoBasket equiB2 = new EquipoBasket("lanusSocial", DateTime.Today);
            EquipoBasket equiB3 = new EquipoBasket("Esgrima", DateTime.Today);

            EquipoFutbol equiF1 = new EquipoFutbol("river", DateTime.Today);
            EquipoFutbol equiF2 = new EquipoFutbol("boca", DateTime.Today);
            EquipoFutbol equiF3 = new EquipoFutbol("lanus", DateTime.Today);

            torneBasket += equiB1;
            torneBasket += equiB2;
            torneBasket += equiB3;

            torneFutbol += equiF1;
            torneFutbol += equiF2;
            torneFutbol += equiF3;

            Console.WriteLine(torneFutbol.Mostrar());
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine(torneBasket.Mostrar());
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine(torneFutbol.JugarPartido);
            Console.WriteLine(torneFutbol.JugarPartido);
            Console.WriteLine(torneFutbol.JugarPartido);
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine(torneBasket.JugarPartido);
            Console.WriteLine(torneBasket.JugarPartido);
            Console.WriteLine(torneBasket.JugarPartido);
            Console.ReadKey();

        }
    }
}
