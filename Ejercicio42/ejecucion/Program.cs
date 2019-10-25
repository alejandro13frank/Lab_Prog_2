using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio42;
using IO;
namespace ejecucion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase.metodo();
            }
            catch (UnaEsepcion perro)
            {
                Console.WriteLine("hola esepcion {0}\n", perro.Message);
                ArchivTexto.Guardar("archiv.txt", perro.Message);
                Console.WriteLine("hola esepcion {0}\n", perro.StackTrace);
                ArchivTexto.Guardar("archiv.txt", perro.Message);
                Console.WriteLine("hola esepcion {0}\n", perro.InnerException.Message);
                Console.WriteLine("hola esepcion {0}\n\n\n", perro.InnerException.InnerException.Message);
                Console.WriteLine("hola esepcion {0}\n", perro.InnerException.InnerException.InnerException.StackTrace);
                Console.ReadKey();
            }

        }
    }
}
