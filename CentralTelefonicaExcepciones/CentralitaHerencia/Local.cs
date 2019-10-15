using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        public Local(string origen, float duracion, string destino, float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo):this (llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {

        }
        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }
        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0} , costo de llamada: {1}", base.Mostrar(), this.CostoLlamada);
            return stringBuilder.ToString();
        }
        public override bool Equals(object obj)
        {
          return obj is Provincial;
        }
        public override string ToString()
        {
          return this.Mostrar();
        }
    }
    
}
