using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza: Botella
    {
        private const int MEDIDA=330;
        Tipo tipo;

        public Cerveza(string marca, int capacidadML, int contenidoML):this(marca, capacidadML, contenidoML,Tipo.Vidrio)
        {

        }
        public Cerveza(string marca, int capacidadML, int contenidoML, Tipo tipo):base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }
        protected override string GenerarInforme()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.GenerarInforme());
            stringBuilder.AppendLine($"Medida: {Cerveza.MEDIDA}");
            stringBuilder.AppendLine($"Tipo: {this.tipo}");
            return stringBuilder.ToString();
        }
        public override int ServirMedida()
        {
            if ( MEDIDA <= this.contenidoML)
            {
                this.contenidoML -= (MEDIDA*80)/100;
                return (MEDIDA * 80) / 100;
            }
            else
            {
                int medidaAux = contenidoML;
                contenidoML -= contenidoML;
                return medidaAux;
            }
             
        }
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
    
}
