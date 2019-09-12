using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Peso
    {
        double cantidad;
        static double cotizacionRespectoDolar;

        public Peso()
        {
            Peso.cotizacionRespectoDolar = 38.33;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotizacionRespectoDolar = cotizacion;
        }
        public static explicit operator Dolar(Peso a)
        {
            Dolar aux = new Dolar(a.getCantidad() / Peso.getCotizacion());
            return aux;
        }
        public static explicit operator Euro(Peso a)
        {
            Euro aux = (Euro)((Dolar)a);
            return aux;
        }
        
        public static implicit operator Peso(double a)
        {
            Peso aux = new Peso(a);
            return aux;
        }

        public static double getCotizacion()
        {
            return cotizacionRespectoDolar;
        }
        public double getCantidad()
        {
            return this.cantidad;
        }

        public static Peso operator +(Peso a, Peso b)
        {
            return (a.getCantidad() + b.getCantidad());
        }

        public static Peso operator +(Peso a, Euro b)
        {
            return (a + (Peso)b);
        }

        public static Peso operator +(Peso a, Dolar b)
        {
            return (a + (Peso)b);
        }

        public static Peso operator -(Peso a, Peso b)
        {
            return (a.getCantidad() - b.getCantidad());
        }

        public static Peso operator -(Peso a, Euro b)
        {
            return (a - (Peso)b);
        }

        public static Peso operator -(Peso a, Dolar b)
        {
            return (a - (Peso)b);
        }

        public static bool operator ==(Peso a, Euro b)
        {
            bool retorno = false;
            if (a.getCantidad() == b.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ==(Peso a, Dolar b)
        {

            bool retorno = false;
            if (a.getCantidad() == b.getCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Peso a, Dolar b)
        {
            return !(a == b);
        }
        public static bool operator !=(Peso a, Euro b)
        {
            return !(a == b);
        }

        public static bool operator ==(Peso a, Peso b)
        {
            bool retorno = false;
            if (a.getCantidad() == b.getCantidad())
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Peso a, Peso b)
        {
            return !(a == b);
        }

    }
}
