using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
            
        public void CalcularFinal()
        {
            System.Threading.Thread.Sleep(150);
            Random cosa = new Random();
            if (this.nota1>=4 && this.nota2>=4)
            {
                this.notaFinal = cosa.Next(1,10);

            }
            else
            {
                this.notaFinal = -1;
            }
        }
        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            string texto="";
            if (this.notaFinal != -1)
            {
                texto = "Nombre: " + this.nombre + "\n" +
                "Apellido: " + this.apellido + "\n" +
                "legajo: " + this.legajo + "\n" +
                "nota 1: " + this.nota1 + "\n" +
                "nota 2: " + this.nota2 + "\n" +
                "Nota final: " + this.notaFinal + "\n";
            }
            else
            {
                texto = "alumno Desaprobado" +
                "Nombre: " + this.nombre + "\n" +
                "Apellido: " + this.apellido + "\n" +
                "legajo: " + this.legajo + "\n";
            }
            return texto;

        }
    }
}
