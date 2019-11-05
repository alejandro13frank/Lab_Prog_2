using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;
namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClase> clasesDelDia;
        private static Random random;

        private void _randomClase()
        {
            this.clasesDelDia.Enqueue((Universidad.EClase)random.Next(0,3));
            this.clasesDelDia.Enqueue((Universidad.EClase)random.Next(0, 3));
        }
        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{base.ToString()}");
            foreach (Universidad.EClase clase  in this.clasesDelDia)
            {
                stringBuilder.AppendLine($"clase: {clase.ToString()}");
            }
            return stringBuilder.ToString();
        }
        protected override string ParticiparEnClase()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("CLASES DEL DIA");
            foreach (Universidad.EClase clase in this.clasesDelDia)
            {
                stringBuilder.AppendLine($"{clase.ToString()}");   
            }
            return stringBuilder.ToString();
        }
        public Profesor()
        {

        }
        static Profesor()
        {
            random=new Random();
        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad): base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClase>();
            this._randomClase();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        public static bool operator ==(Profesor i,Universidad.EClase clase)
        {
            foreach (Universidad.EClase auxClase in i.clasesDelDia)
            {
                if (clase == auxClase)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Profesor i, Universidad.EClase clase)
        {
            return !(i == clase);
        }
    }
}
