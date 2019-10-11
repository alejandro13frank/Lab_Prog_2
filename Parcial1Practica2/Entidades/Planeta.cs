using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Planeta : Astro
    {
        int cantSatelites;
        Tipo tipo;
        List<Astro> satelites;

        public List<Astro> Satelites
        {
            get
            {
               return this.satelites;
            }
        }
        public override string Orbitar()
        {
            return $"Orbita el planeta: {(string)this}.";
        }
        public Planeta(int duracionOrbita, int duracionRotacion, string nombre, int cantSatelites,Tipo tipo):base(duracionOrbita, duracionRotacion, nombre)
        {
            this.satelites = new List<Astro>();
            this.tipo = tipo;

        }
        public Planeta(int duracionOrbita, int duracionRotacion, string nombre): this(duracionOrbita,duracionRotacion,nombre,1,Tipo.Rocoso)
        {

        }
        public new string Rotar()
        {
            return $"Orbita el planeta {nombre}";
        }
        public static bool operator ==(Planeta p1,Planeta p2)
        {
            return (string)p1 == (string)p2;
        }
        public static bool operator !=(Planeta p1, Planeta p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Planeta p1, Satelite s1)
        {
            foreach (Satelite s in p1.Satelites)
            {
                if ((string)s==(string)s1)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Planeta p1, Satelite s1)
        {
            return !(p1 == s1);
        }
        public static Planeta operator +(Planeta p1,Satelite satelite)
        {
            if ((satelite is Satelite) && p1!=satelite)
            {
                p1.satelites.Add(satelite);
            }
            return p1;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Mostrar());
            sb.AppendLine($"Cantidad de satelites: {this.cantSatelites} - Tipo: {this.tipo}");
            foreach (Satelite satelite in this.Satelites)
            {
                sb.AppendLine(satelite.ToString());
            }
            
            return sb.ToString();
        }

    }
}
