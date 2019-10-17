using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(string marca, int capacidadML, int contenidoML):base(marca, capacidadML, contenidoML)
        {

        }
        protected override string GenerarInforme()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.GenerarInforme());
            stringBuilder.AppendLine($"Medida: {Agua.MEDIDA}");
            return stringBuilder.ToString();
        }
        public override int ServirMedida()
        {
            return ServirMedida(Agua.MEDIDA);
        }
        public int ServirMedida(int medida)
        {
            if (medida<= this.contenidoML)
            {
                this.contenidoML -= medida;
                return medida;
            }      
            else
            {
                int medidaAux = contenidoML;
                contenidoML -= contenidoML;
                return medidaAux;

            }
            
        }


    }
}
