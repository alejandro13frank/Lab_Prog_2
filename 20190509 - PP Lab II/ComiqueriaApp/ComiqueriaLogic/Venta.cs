using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        internal DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }
        static Venta()
        {
            porcentajeIva = 21;
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }
        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecio(this.producto.Precio, cantidad);
        }
        public static double CalcularPrecio(double precio,int cantidad)
        {
            return (precio * cantidad) + ((precio * cantidad) * ((double)Venta.porcentajeIva / 100));
        }
        public string ObtenerDescripcionBreve()
        {
            return $"{this.Fecha} - {this.producto.Descripcion} - {this.precioFinal:00}\n";
        }

    }
}
