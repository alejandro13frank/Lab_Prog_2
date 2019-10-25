using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class EquipoBasket : Equipo
    {
        public EquipoBasket(string nombre, DateTime fecha)
        {
            this.fecha = fecha;
            this.nombre = nombre;
        }
    }
}
