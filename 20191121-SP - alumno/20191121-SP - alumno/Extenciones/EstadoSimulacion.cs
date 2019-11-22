using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extenciones
{
    public static class EstadoSimulacion
    {
        public static string EstadoSimulation(this string estado, bool parametro)
        {
            if (parametro)
            {
                return "Orbitando";
            }
            else
            {
                return "Detenido";
            }
        }
    }
}
