using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador(int a)
        {
            cantidadSumas = a;
        }
        public Sumador()
        {
            cantidadSumas = 0;
        }
        public long Sumar(long a,long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public int GetCantidadSumas()
        {
            return this.cantidadSumas;
        }
        public static explicit operator int(Sumador s1)
        {
            return s1.GetCantidadSumas();
        }

        public static long operator +(Sumador s1,Sumador s2)
        {
            return s1.GetCantidadSumas() + s2.GetCantidadSumas();   
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;
            if (s1.GetCantidadSumas()==s2.GetCantidadSumas())
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
