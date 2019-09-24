using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;
        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad
        {
            get;
        }

        public abstract string MiMetodo();
       
        public override string ToString()
        {
            return "este es mi pene largo y poderoso";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
