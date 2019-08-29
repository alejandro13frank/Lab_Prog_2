using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor colorNuevo,short cantTinta)
        {
            color = colorNuevo;
            tinta = cantTinta;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        private void setTinta(short tinta)
        {
            if ((tinta + this.tinta) >= 0 && (tinta + this.tinta) <= cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
        }
        public void Recargar()
        {
            this.setTinta((short)(cantidadTintaMaxima - this.tinta));
        }
        public bool Pintar(short gasto,out string dibujo)
        {
            int i;
            dibujo = "";
            for (i=gasto;i>0 && this.tinta>0;i--)
            {
                dibujo += "*";
                this.setTinta(-1);
            }
            return true;
        }
    
    }
}
