using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Torneo<T> where T:Equipo
    {
        List<T> equipos;
        string nombre;

        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            foreach (var e in torneo.equipos)
            {
                if (e==equipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo.equipos == equipo);
        }
    }
}
