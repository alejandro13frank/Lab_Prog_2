using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;
        public enum Franja
        {
            Franja_1=99,
            Franja_2=125,
            Franja_3=66
        }
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        private float CalcularCosto()
        {
            float aux = (float)this.franjaHoraria / 100;
            return this.Duracion * aux;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0} , costo de llamada: {1}", base.Mostrar(), this.CostoLlamada);
            return stringBuilder.ToString();
        }
    }
}
