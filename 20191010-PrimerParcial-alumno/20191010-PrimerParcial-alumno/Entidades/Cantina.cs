using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        List<Botella> botellas;
        static int espaciosTotales;
        static Cantina singleton;

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }        
        }
        private Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
            espaciosTotales = espacios;
        }
        public static Cantina GetCantina(int espacios)
        {
            if (singleton==null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                espaciosTotales = espacios;
            }
            return singleton;
        }
        public static bool operator +(Cantina cantina,Botella b)
        {
            try
            {
                if (espaciosTotales>=1)
                cantina.botellas.Add(b);
                espaciosTotales--;
            }
            catch
            {
                return false;
            }
            return true;
        }

            
    }
}
