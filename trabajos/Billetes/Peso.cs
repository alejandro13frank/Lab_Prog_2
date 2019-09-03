using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        public Peso()
        {
            cantidad = 0;
            cotizRespectoDolar = 38.33;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
            cotizRespectoDolar = 1;
        }
        public Peso(double cantidad, double cotizacion)
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
        public static explicit operator Dolar(Peso p)
        {
            double cotizado = p.GetCantidad() * Peso.GetCotizacion();
            Dolar d = new Dolar(cotizado);
            return d;
        }
        public static explicit operator Euro(Peso p)
        {
            Dolar d = (Dolar)p;
            Euro e= (Euro)d;
            return e;
        }
        public static implicit operator Peso(Double doble)
        {
            Peso nuevoPeso = new Peso(doble);
            return nuevoPeso;
        }
        public static bool operator ==(Peso d, Peso p)
        {
            return (d.GetCantidad() == p.GetCantidad());
        }
        public static bool operator ==(Peso d, Euro p)
        {
            return (p.GetCantidad() == ((Euro)d).GetCantidad());
        }
        public static bool operator ==(Peso d, Dolar p)
        {
            return (d.GetCantidad() == ((Dolar)p).GetCantidad());
        }
        public static bool operator !=(Peso d, Peso p)
        {
            return !(d.GetCantidad() == p.GetCantidad());
        }
        public static bool operator !=(Peso d, Euro p)
        {
            return !(p.GetCantidad() == ((Euro)d).GetCantidad());
        }
        public static bool operator !=(Peso d, Dolar p)
        {
            return !(d.GetCantidad() == ((Dolar)p).GetCantidad());
        }
    }
}
