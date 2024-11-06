using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    abstract class Clientes
    {
        public string altaCliente(E_Cliente cliente, bool esSocio)
        {
            MySqlParameter[] parametros = {
                new MySqlParameter("Nom", MySqlDbType.VarChar) { Value = cliente.Nombre },
                new MySqlParameter("Ape", MySqlDbType.VarChar) { Value = cliente.Apellido },
                new MySqlParameter("Tip", MySqlDbType.VarChar) { Value = cliente.TipoDoc },
                new MySqlParameter("Doc", MySqlDbType.Int32) { Value = cliente.Documento },
                new MySqlParameter("ApFis", MySqlDbType.Bit) { Value = cliente.AptoFisico },
                new MySqlParameter("esSocio", MySqlDbType.Bit) { Value = esSocio }
            };

            return Conexion.ejecutarProcedimiento("NuevoCliente", parametros);
        }

        public static string identificarTipoCliente(int idCliente)
        {
            MySqlParameter[] parametros = {
                new MySqlParameter("Cli", MySqlDbType.Int32) { Value = idCliente }
            };

            return Conexion.ejecutarProcedimiento("ObtenerTipoCliente", parametros);
        }
    }       
}
