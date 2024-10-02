using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Usuarios
    {
        public DataTable usuarioLog(string nombreUsuario, string pass)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand
                ("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Usuario",
                MySqlDbType.VarChar).Value = nombreUsuario;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value =
                pass;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado); 
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }
    }
}
