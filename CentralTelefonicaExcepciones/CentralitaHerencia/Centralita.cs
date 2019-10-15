using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return Llamadas;
            }
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float costoTotal = 0;
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if ((tipo==Llamada.TipoLlamada.Local || 
                    tipo==Llamada.TipoLlamada.Todas) && 
                    (llamada is Local))
                {
                    costoTotal += ((Local)llamada).CostoLlamada;
                }
                else if ((tipo == Llamada.TipoLlamada.Provincial ||
                        tipo == Llamada.TipoLlamada.Todas) &&
                        (llamada is Provincial))
                {
                    costoTotal += ((Provincial)llamada).CostoLlamada;
                }
            }
            return costoTotal;
        }
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Razon social: {0}\nGananciasPorLocal: {1}\nGananciaPorProvicial: {2}\n");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                {
                    stringBuilder.Append(((Local)llamada).ToString());
                }
                else
                {
                    stringBuilder.Append(((Provincial)llamada).ToString());
                }
            }
            return stringBuilder.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }
        public static bool operator ==(Centralita c,Llamada llamada)
        {
            foreach (Llamada call in c.listaDeLlamadas)
            {
               if (call==llamada)
               {
                  return true;
               }
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (c!=llamada)
            {
              c.AgregarLlamada(llamada);
            }
            else
            {
              throw new CentralitaException("Aviso: la llamada ya estaba registrada",c.ToString(),"Metodo operador +");
            }
            return c;
        }
    }
}
