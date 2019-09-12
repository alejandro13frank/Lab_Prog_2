using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda

{
    public class Euro
    {
        double cantidad;
        public static double cotizRespectoDolar;

        public Euro()
        {
            Euro.cotizRespectoDolar = 1.16;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this (cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public static explicit operator Dolar(Euro a)
        {
            Dolar aux = new Dolar(a.GetCantidad() / Euro.GetCotizacion());
            return aux;
        }
        public static explicit operator Peso(Euro a)
        {
            Peso aux = (Peso)((Dolar)a);
            return aux;
        }
        
        public static implicit operator Euro(double a)
        {
            Euro aux = new Euro(a);
            return aux;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static Euro operator +(Euro a, Euro b)
        {
            return (a.GetCantidad() + b.GetCantidad());
        }

        public static Euro operator +(Euro a, Dolar b)
        {
            return (a + (Euro)b);
        }

        public static Euro operator +(Euro a, Peso b)
        {
            return (a + (Euro)b);
        }

        public static Euro operator -(Euro a, Euro b)
        {
            return (a.GetCantidad() - b.GetCantidad());
        }

        public static Euro operator -(Euro a, Dolar b)
        {
            return (a - (Euro)b);
        }

        public static Euro operator -(Euro a, Peso b)
        {
            return (a - (Euro)b);
        }
        public static bool operator ==(Euro a, Peso b)
        {
            bool retorno = false;
            if (a.GetCantidad() == b.getCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Euro a, Dolar b)
        {

            bool retorno = false;
            if (a.GetCantidad() == b.getCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Euro a, Peso b)
        {
            return !(a == b);
        }
        public static bool operator !=(Euro a, Dolar b)
        {
            return !(a == b);
        }

        public static bool operator ==(Euro a, Euro b)
        {
            bool retorno = false;
            if (a.GetCantidad() == b.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Euro a, Euro b)
        {
            return !(a == b);
        }
    }
}
