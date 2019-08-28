using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.nombre = "alejandro1";
            alumno1.apellido = "frank1";
            alumno1.legajo = 1313;

            alumno2.nombre = "alejandro2";
            alumno2.apellido = "frank2";
            alumno2.legajo = 1213;

            alumno3.nombre = "alejandro3";
            alumno3.apellido = "frank3";
            alumno3.legajo = 1113;

            alumno1.Estudiar(5, 5);
            alumno2.Estudiar(5, 6);
            alumno3.Estudiar(5, 8);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
