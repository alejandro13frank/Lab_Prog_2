using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetecia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;       
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetecia;
            }
            set
            {
                this.enCompetecia = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public AutoF1(short numero,string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetecia = false;
            this.vueltasRestantes = 0;
            this.cantidadCombustible =0;
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1.numero==a2.numero && a1.escuderia==a2.escuderia)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public string MostrarDato()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"cantidadCombustible:{this.cantidadCombustible}\nenCompetecia:{this.enCompetecia}\nescuderia:{this.escuderia}\nnumero:{this.numero}\nvueltasRestantes:{this.vueltasRestantes}\n");
            return stringBuilder.ToString();
        }
    }
}
