using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Satelite : Astro
    {
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public override string Orbitar()
        {
            return $"Orbitar el satelite: {nombre}";
        }
        public Satelite(int duracionOrbita, int duracionRotacion, string nombre): base(duracionOrbita, duracionRotacion, nombre)
        {

        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
