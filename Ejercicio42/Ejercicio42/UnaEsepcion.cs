using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio42
{
    public class UnaEsepcion:Exception
    {
        public UnaEsepcion()
        {
            
        }
        public UnaEsepcion(string mensaje) : base(mensaje)
        {

        }
        public UnaEsepcion(string mensaje, Exception inner) : base(mensaje,inner)
        {

        }
    }
    
         
}
