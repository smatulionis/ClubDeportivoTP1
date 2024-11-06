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
    internal class Inscripcion
    {
        public string nuevaInscripcion(E_Inscripcion inscripcion)
        {
            MySqlParameter[] parametros = {
                new MySqlParameter("Cli", MySqlDbType.Int32) { Value = inscripcion.IdCliente },
                new MySqlParameter("Act", MySqlDbType.Int32) { Value = inscripcion.IdActividad }
            };

            return Conexion.ejecutarProcedimiento("InscribirCliente", parametros);
        }
    }
}
