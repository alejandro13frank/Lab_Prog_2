using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {

        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        public enum Tipo
        {
            Vidrio,
            Plastico
        }
        public int CapacidadLitros
        {
            get
            {
                return capacidadML / 1000;
            }
        }
        public int Contenido
        {
            get
            {
                return capacidadML / 1000;
            }
            set
            {
                this.contenidoML = value;
            }
        }
        public float PorcentajeContenido
        {
            get
            {

                return (float)(contenidoML*100)/capacidadML;
            }
            //no entendi con que hacer la relacion de 3
            //Ahora lo entendi, era facil estaba nervioso

        }
        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            if (capacidadML<contenidoML)
            {
                contenidoML = capacidadML;
            }
            this.capacidadML = capacidadML;
            this.contenidoML = contenidoML;
        }
        protected virtual string GenerarInforme()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Marca: {0} \nCapacidad: {1} \nContenido: {2} \nPorcentaje: {3}%",
                                        this.marca, this.capacidadML, this.contenidoML, this.PorcentajeContenido);
            return stringBuilder.ToString();
        }
        public abstract int ServirMedida();
       
        public override string ToString()
        {
            return this.GenerarInforme();
        }

    }
}
