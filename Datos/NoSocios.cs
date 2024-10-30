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
    class NoSocios : Clientes
    {
        public string nuevoCliente(E_NoSocio noSocio)
        {
            return altaCliente(noSocio, false);
        }
    }
}
