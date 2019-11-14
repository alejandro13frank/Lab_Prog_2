using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class Dao : IArchivo<Votacion>
    {
        public Votacion Leer(string estring)
        {
            throw new NotImplementedException();
        }
        public bool Guardar (string letras, Votacion votacion)
        {
            String connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog =votacion-sp-2018; Integrated Security = True";
            SqlConnection conexion;
            conexion = new SqlConnection(connectionStr);
            SqlCommand comando;

            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;

            comando.Connection = conexion;
            String update;
            update = $"INSERT INTO dbo.Votaciones (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno)  VALUES ('{votacion.NombreLey}',{votacion.ContadorAfirmativo},{votacion.ContadorNegativo},{votacion.ContadorAbtencion},'alejandro,frank')";

            comando.CommandText = update;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception();
            }
            

            finally
            {
                conexion.Close();
               
            }
            return true;
        }
    }
}
