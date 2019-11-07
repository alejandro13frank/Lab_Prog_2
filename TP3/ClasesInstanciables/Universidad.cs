using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClase
        {
            Programacion=0,
            Laboratorio=1,
            Legislacion=2,
            SPD=3
        }
        List<Alumno> alumnos;
        List<Jornada> jornadas;
        List<Profesor> instructores;

        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }
        public List<Profesor> Instructores
        {
            get
            {
                return this.instructores;
            }
            set
            {
                this.instructores = value;
            }
        }
        public Jornada this[int i]
        {
            get
            {
                return this.Jornadas[i];
            }
            set
            {
                this.Jornadas[i] = value;
            }       
        }
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno.Equals(a))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator ==(Universidad g, Profesor p)
        {
            foreach (Jornada jornada in g.Jornadas) 
            {
                if (jornada.Instructor.Equals(p))
                {
                    return true;
                }
            }
            return false;
        }
        public static Profesor operator ==(Universidad u, EClase clase)
        {

            return new Profesor(); 
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        public static bool operator !=(Universidad g, Profesor p)
        {
            return !(g == p);
        }
        public static Profesor operator !=(Universidad u, EClase clase)
        {
            return new Profesor();
        }
        public static Universidad operator +(Universidad g, EClase clase)
        {

            Jornada jornada = null;
            foreach (Profesor profesor in g.Instructores)
            {
                if (profesor==clase)
                {
                    jornada = new Jornada(clase, profesor);
                }
            }
            if (jornada != null)
            {
                foreach(Alumno alumno in g.Alumnos)
                {
                    if (alumno==clase)
                    {
                        jornada += alumno;
                    }
                }
                g.Jornadas.Add(jornada);
            }
            return g;
        }
        public static Universidad operator +(Universidad g, Alumno a)
        {
            
            return g;
        }
        public static Universidad operator +(Universidad g, Profesor p)
        {
            return g;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public Universidad()
        {

        }
        public bool Guadar(Universidad uni)
        {
            return true;
        }
        public Universidad Leer()
        {
            return new Universidad();
        }
    }
}
