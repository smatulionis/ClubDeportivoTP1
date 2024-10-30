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
    class Socios : Clientes
    {
        public string nuevoCliente(E_Socio socio)
        {
            return altaCliente(socio, true);
        }
    }
}
