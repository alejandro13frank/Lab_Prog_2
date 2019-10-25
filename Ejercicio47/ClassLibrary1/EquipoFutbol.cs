using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class EquipoFutbol : Equipo
    {
        public EquipoFutbol(string nombre, DateTime fecha)
        {
            this.fecha = fecha;
            this.nombre = nombre;
        }
    }
}
