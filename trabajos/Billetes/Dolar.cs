using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        public Dolar()
        {
            cantidad = 0;
            cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad, double cotizacion)
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
        public static explicit operator Euro(Dolar d)
        {
            double cotizado = d.GetCantidad() * Euro.GetCotizacion();
            Euro e = new Euro(cotizado);
            return e;
        }
        public static explicit operator Peso(Dolar d)
        {
            double cotizado = d.GetCantidad() * Peso.GetCotizacion();
            Peso p = new Peso(cotizado);
            return p;
        }
        public static implicit operator Dolar(Double doble)
        {
            Dolar nuevoDolar = new Dolar(doble);
            return nuevoDolar;
        }
        public static bool operator ==(Dolar d, Dolar p)
        {
            return (d.GetCantidad() == p.GetCantidad());
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.GetCantidad() == ((Dolar)p).GetCantidad());
        }
        public static bool operator ==(Dolar d, Euro p)
        {
            return (d.GetCantidad() == ((Dolar)p).GetCantidad());
        }
        public static bool operator !=(Dolar d, Dolar p)
        {
            return !(d.GetCantidad() == p.GetCantidad());
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d.GetCantidad() == ((Dolar)p).GetCantidad());
        }
        public static bool operator !=(Dolar d, Euro p)
        {
            return !(d.GetCantidad() == ((Dolar)p).GetCantidad());
        }
    }
}
