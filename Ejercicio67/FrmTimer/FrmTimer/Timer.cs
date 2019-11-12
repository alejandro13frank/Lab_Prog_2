using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FrmTimer
{
    public delegate void EncargadoTiempo();
    public class Timer
    {
        Thread hilo;
        int intervalo;
        public event EncargadoTiempo eventoTiempo; 
        bool activo;
        public Timer()
        {
            hilo = new Thread(this.Corriendo);
            this.Intervalo = 1000;
        }
        public bool Activo
        {
            get
            {
                return this.activo;
            }
            set
            {
                if (value)
                {
                    this.activo = value;
                    this.hilo.Start();
                }
                else
                {
                    this.activo = value;
                    this.hilo.Abort();
                }
            }
        }
        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }
        private void Corriendo()
        {
            do
            {
               System.Threading.Thread.Sleep(this.Intervalo);
               this.eventoTiempo.Invoke();
            } while (true);
        }

    }
}
