using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class Dao
    {
        public void Leer()
        {
            throw new NotImplementedException();
        }
        public void Guardar (Votacion votacion)
        {
            String connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog =votacion-sp-2018; Integrated Security = True";
            SqlConnection conexion;
            conexion = new SqlConnection(connectionStr);
            SqlCommand comando;

            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;

            comando.Connection = conexion;
            String update;
            update = $"INSERT dbo.Votaciones SET nombreLey = '{votacion.NombreLey}' WHERE id = 1 ";

            comando.CommandText = update;
            conexion.Open();
            comando.ExecuteNonQuery();
        }
    }
}
