using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class SistemaSolar
    {
        List<Astro> planetas;

        public List<Astro> Planetas
        {
            get
            {
                return this.planetas;
            }
        }
        private SistemaSolar()
        {
            this.planetas = new List<Astro>();
        }
        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Planeta planeta in this.Planetas)
            {
                sb.AppendLine(planeta.ToString());
            }
            return sb.ToString();
        }
    }
}
