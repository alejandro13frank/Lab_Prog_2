using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static string MostrarProduto(Producto p)
        {
            if(p is null)
            {
                return null;
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca: {0}\bPrecio: {1} CodigoDeBarra: {2}\n", p.GetMarca(), (p.GetPrecio()).ToString(), (string)p);
            return sb.ToString();
        }
        public static bool operator ==(Producto a,Producto b)
        {
            if ((a is null) || (b is null))
            {
                return false;
            }
            return (a.GetMarca() == b.GetMarca() && (string)a == (string)b);
        }
        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }
        public static bool operator ==(Producto a, string marca)
        {
            return (a.GetMarca()==marca);
        }
        public static bool operator !=(Producto a, string marca)
        {
            return !(a == marca);
        }
    }
}
