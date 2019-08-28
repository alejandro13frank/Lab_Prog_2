using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Consversor
    {
        public static string DecimalBinario(double numero)
        {
            string resto = "";
            string binario = "";
            while ((numero >= 2))
            {
                resto = resto + (numero % 2).ToString();
                numero = numero / 2;
            }
            resto = resto + numero.ToString();
            for (int i = resto.Length; i >= 1; i += -1)
            {
                binario = binario + resto.Substring(i - 1, 1);
            }
            return binario;
        }
        public static double BinaioDecimal(string numero)
        {
            
        }
    }
}
