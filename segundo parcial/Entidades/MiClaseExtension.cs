using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MiClaseExtension
    {
        public static string EstadoSimulacion(this String nombre, bool param)
        {
            if (param == true)
                return "Orbitando";
            else
                return "Detenido";
        }
    }
}
