using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Cuota
    {
        public void pagarCuota(E_Cuota cuota)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("AbonarCuota",
                sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Cli", MySqlDbType.Int32).Value =
                cuota.IdCliente;
                comando.Parameters.Add("Monto", MySqlDbType.Float).Value =
                cuota.Monto;
                comando.Parameters.Add("Fecha", MySqlDbType.Date).Value =
                cuota.Fecha;
                comando.Parameters.Add("FPago", MySqlDbType.VarChar).Value =
                cuota.FormaPago;

                sqlCon.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar el pago: " + ex.Message);
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }
    }
}
