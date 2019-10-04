using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio42
{
    public class OtraClase
    {
        public static void metodo()
        {
            int numero=0;
            try
            {
                MiClase objeto = new MiClase(numero);
            }
            catch (DivideByZeroException gato)
            {
                throw new UnaEsepcion("ececion nueva", gato);
            }
            
        }
    }
}
