using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.nroOrigen = nroOrigen;
            this.duracion = duracion;
            this.nroDestino = nroDestino;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("duracion: {0} , nroOrigen: {1} , nroDestino: {2}", this.Duracion, this.NroOrigen, this.NroDestino);
            return stringBuilder.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }

    }
}
