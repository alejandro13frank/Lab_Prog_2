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
        private Universidad.EClase claseQueToma;
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
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClase claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClase claseQueToma, EEstadoCuenta estadoCuenta) : this (id, nombre, apellido, dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        protected override string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{base.ToString()}");
            stringBuilder.AppendLine($"TOMA CLASES DE: {this.claseQueToma.ToString()}");
            stringBuilder.AppendLine($"ESTADO DE CUENTA: {this.estadoCuenta.ToString()}");
            return stringBuilder.ToString();
        }
        protected override string ParticiparEnClase()
        {
            return $"TOMA CLASE DE {this.claseQueToma.ToString()}";
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        public static bool operator ==(Alumno a, Universidad.EClase clase)
        {
            return a.estadoCuenta!=EEstadoCuenta.Deudor && a.claseQueToma==clase;
        }
        public static bool operator !=(Alumno a, Universidad.EClase clase)
        {
            return !(a.claseQueToma==clase);
        }
    }
}
