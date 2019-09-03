using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        public Euro()
        {
            cantidad = 0;
            cotizRespectoDolar = 1.16;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = 1;
        }
        public Euro(double cantidad, double cotizacion)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = cotizacion;
        }
        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static explicit operator Dolar(Euro e)
        {
            double cotizado = e.GetCantidad() * Euro.GetCotizacion();
            Dolar d = new Dolar(cotizado);
            return d;
        }
        public static explicit operator Peso(Euro e)
        {
            Dolar d = (Dolar)e;
            Peso P = (Peso)d;
            return P;
        }
        public static implicit operator Euro(Double doble)
        {
            Euro nuevoEuro = new Euro(doble);
            return nuevoEuro;
        }
        public static bool operator ==(Euro d, Euro p)
        {
            return (d.GetCantidad() == p.GetCantidad());
        }
        public static bool operator ==(Euro d, Peso p)
        {
            return (d.GetCantidad() == ((Euro)p).GetCantidad());
        }
        public static bool operator ==(Euro d, Dolar p)
        {
            return (p.GetCantidad() == ((Dolar)d).GetCantidad());
        }
        public static bool operator !=(Euro d, Euro p)
        {
            return !(d.GetCantidad() == p.GetCantidad());
        }
        public static bool operator !=(Euro d, Peso p)
        {
            return !(d.GetCantidad() == ((Euro)p).GetCantidad());
        }
        public static bool operator !=(Euro d, Dolar p)
        {
            return !(p.GetCantidad() == (Dolar)d.GetCantidad());
        }
    }
}
