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
        public string pagarCuota(E_Cuota cuota)
        {
            MySqlParameter[] parametros = {
                new MySqlParameter("Cli", MySqlDbType.Int32) { Value = cuota.IdCliente },
                new MySqlParameter("Monto", MySqlDbType.Float) { Value = cuota.Monto },
                new MySqlParameter("Fecha", MySqlDbType.Date) { Value = cuota.Fecha },
                new MySqlParameter("FPago", MySqlDbType.VarChar) { Value = cuota.FormaPago }
            };

            return Conexion.ejecutarProcedimiento("AbonarCuota", parametros);
        }
    }
}
