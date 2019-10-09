using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum Tipo
    {
        Rocoso,
        Gaseoso
    }
    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;
        
        public Astro(int duracionOrbita, int duracionRotacion, string nombre)
        {
            this.duracionOrbita = duracionOrbita;
            this.duracionRotacion = duracionRotacion;
            this.nombre = nombre;
        }
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre} - Órbita: {duracionOrbita} -Rotación: {duracionRotacion}");
            return sb.ToString();
        }
        public abstract string Orbitar();

        public virtual string Rotar()
        {
            return $"Rotando. Tiempo estimado: {duracionRotacion}.";
        }

        public static explicit operator string(Astro astro)
        {
            return astro.nombre;
        }
    }
}
