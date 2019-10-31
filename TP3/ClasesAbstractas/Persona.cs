using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad
        {
            Argentino,
            Extrangero
        }
        string nombre;
        string apellido;
        int dni;
        ENacionalidad nacionalidad;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        public string StringToDNI
        {
            set
            {
                this.dni = int.Parse(value);
            }
        }
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {

        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre,apellido,dni.ToString(),nacionalidad) 
        {

        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad): this(nombre, apellido, nacionalidad)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
