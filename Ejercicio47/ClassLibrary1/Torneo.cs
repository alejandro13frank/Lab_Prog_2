using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Torneo<T> where T:Equipo
    {
        List<T> equipos;
        string nombre;

        public string JugarPartido
        {
            get
            {
                System.Threading.Thread.Sleep(200);
                Random random = new Random();
                return CalcularPartido(this.equipos[random.Next(0, this.equipos.Count)], this.equipos[random.Next(0, this.equipos.Count)]);
            }
        }
        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (var e in torneo.equipos)
            {
                if (e==equipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo!=equipo)
            {
                torneo.equipos.Add(equipo);  
            }
            return torneo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre de torneo: {this.nombre}");
            foreach (var team in this.equipos)
            {
                sb.AppendLine(team.Ficha());
            }
            return sb.ToString();
        }
        private string CalcularPartido(T e1,T e2)
        {
            Random random = new Random();
            return ($"{e1.nombre} {random.Next(0, 10)} - {e2.nombre} {random.Next(0, 10)}");
        }
    }
}
