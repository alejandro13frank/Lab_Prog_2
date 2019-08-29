using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto uno, Punto tres)
        {
            this.vertice1 = uno;
            this.vertice3 = tres;
            this.vertice2 = new Punto(tres.GetX(), uno.GetY());
            this.vertice4 = new Punto(uno.GetX(), tres.GetY());
        }
        public Punto GetPunto1()
        {
            return this.vertice1;
        }
        public Punto GetPunto2()
        {
            return this.vertice2;
        }
        public Punto GetPunto3()
        {
            return this.vertice3;
        }
        public Punto GetPunto4()
        {
            return this.vertice4;
        }

        public float Area()
        {
            int base1;
            int altura;
            base1 = Math.Abs(this.vertice1.GetX() - this.vertice2.GetX());
            altura = Math.Abs(this.vertice1.GetY() - this.vertice4.GetY());
            this.area = base1 * altura;
            return this.area;
        }
        public float Perimetro()
        {
            int base1;
            int altura;
            base1 = Math.Abs(this.vertice1.GetX() - this.vertice2.GetX());
            altura = Math.Abs(this.vertice1.GetY() - this.vertice4.GetY());
            this.perimetro= base1 + base1 + altura + altura;
            return this.perimetro;
        }
    }
}
