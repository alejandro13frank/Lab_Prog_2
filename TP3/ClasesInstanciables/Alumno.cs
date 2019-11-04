using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClase claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClase claseQueToma, EEstadoCuenta estadoCuenta) : this (id, nombre, apellido, dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"clase:{base.ToString()}");
            stringBuilder.AppendLine($"clase:{this.claseQueToma.ToString()}");
            stringBuilder.AppendLine($"clase:{this.estadoCuenta.ToString()}");
            return stringBuilder.ToString();
        }
        protected override string ParticiparEnClase()
        {
            return $"TOMA CLASE DE {this.claseQueToma.To.String()}";
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        public static bool operator ==(Alumno a,EClase clase)
        {
            return a.estadoCuenta!=EEstadoCuenta.Deudor && a.claseQueToma==clase;
        }
        public static bool operator !=(Alumno a, EClase clase)
        {
            return a.claseQueToma==clase;
        }
    }
}
