﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClase clase;
        private Profesor instructor;
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
        public Universidad.EClase Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        public bool Guardar(Jornada jornada)
        {

            return true;
        }
        public string Leer()
        {
            return "";
        }
        private Jornada()
        {
            this.Alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClase clase, Profesor instructor):this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }
        public static bool operator ==(Jornada j, Alumno a)
        {
            return a == j.Clase;
        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        public static Jornada operator +(Jornada j, Alumno a)
        {
            foreach (Alumno alumno in j.Alumnos)
            {
                if (a==alumno)
                {
                    return j;
                }
            }
            j.Alumnos.Add(a);
            return j;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("JORNADA:");
            stringBuilder.AppendLine($"CLASE DE {this.Clase.ToString()} ");
            stringBuilder.AppendFormat($"{this.Instructor.ToString()}");
            stringBuilder.AppendLine();
            foreach (Alumno alumno in this.Alumnos)
            {
                stringBuilder.AppendLine($"{alumno.ToString()}");
                stringBuilder.AppendLine();
            }
            return stringBuilder.ToString();
        }

    }
}
