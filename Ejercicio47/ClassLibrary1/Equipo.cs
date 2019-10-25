using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fecha;

        public string Ficha()
        {
            return ($"{this.nombre} fundado el {this.fecha.ToString()}");
        }
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return (e1.nombre == e2.nombre && e1.fecha==e2.fecha);
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

    }
}
