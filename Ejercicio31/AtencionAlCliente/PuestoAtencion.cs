using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        public int NumeroActual
        {
            get
            {
                int numero = this.NumeroActual;
                numeroActual++; 
                return numero;
            }
        }
        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(3000);
            return true;
        }
        static PuestoAtencion()
        {
            numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto=puesto;
        }
    }
}
