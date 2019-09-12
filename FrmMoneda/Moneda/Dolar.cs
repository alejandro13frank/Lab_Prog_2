using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {
        double cantidad;
        static double cotizRespectoDolar;

        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static double getCotizacion()
        {
            return cotizRespectoDolar;
        }
         public double getCantidad()
        {
            return this.cantidad;
        }
            
        public static explicit operator Euro(Dolar a)
        {
            Euro aux = new Euro(a.getCantidad() * Euro.GetCotizacion());
            return aux;
        }
        public static explicit operator Peso(Dolar a)
        {
            Peso aux = new Peso(a.getCantidad() * Peso.getCotizacion());
            return aux;
        }
        public static implicit operator Dolar(double a)
        {
            Dolar aux = new Dolar(a);
            return aux;
        }

        public static Dolar operator +(Dolar a, Dolar b)
        {
            return (a.getCantidad() + b.getCantidad());
        }
        
        public static Dolar operator +(Dolar a, Euro b)
        {
            return (a + (Dolar)b);
        }

        public static Dolar operator +(Dolar a, Peso b)
        {
            return (a + (Dolar)b);
        }

        public static Dolar operator -(Dolar a, Dolar b)
        {
            return (a.getCantidad() - b.getCantidad());
        }

        public static Dolar operator -(Dolar a, Euro b)
        {
            return (a - (Dolar)b);
        }

        public static Dolar operator -(Dolar a, Peso b)
        {
            return (a - (Dolar)b);
        }

        public static bool operator ==(Dolar a, Peso b)
        {
            bool retorno = false;
            if (a.getCantidad() == b.getCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Dolar a, Euro b)
        {

            bool retorno = false;
            if (a.getCantidad() == b.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Dolar a, Peso b)
        {
            return !(a == b);
        }
        public static bool operator != (Dolar a, Euro b)
        {
            return !(a == b);
        }

        public static bool operator ==(Dolar a, Dolar b)
        {
            bool retorno = false;
            if (a.getCantidad() == b.getCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Dolar a, Dolar b)
        {
            return !(a == b);
        }
    }
}
