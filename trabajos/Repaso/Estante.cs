using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante (int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad,int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;  
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto p in e.productos)
            {
                sb.Append(Producto.MostrarProduto(p));
            }
            sb.AppendFormat("Ubicacion: {0}\n", (e.ubicacionEstante).ToString());
            return sb.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            foreach (Producto i in e.productos)
            {
                if (i==p)
                {
                    retorno =true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto pNuevo)
        {
            bool retorno = false;
            int i= 0;
            foreach (Producto p in e.productos)
            { 
                if (p is null)
                {
                    break;
                }
                i++;
            }
            bool v = e != pNuevo;
            if (i < e.productos.Length && v)
            {
                retorno = true;
                e.productos[i] = pNuevo;
            }
            return retorno;
        }
        public static Estante operator -(Estante e, Producto pNuevo)
        {
            int i = 0;
            foreach (Producto p in e.productos)
            {
                
                if (p==pNuevo)
                {
                    e.productos[i] = null;
                    break;
                }
                i++;
            }
            return e;
        }

    }
}
