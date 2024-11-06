using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Inscripcion
    {
        public int IdInscripcion { get; private set; }
        public int IdCliente { get; private set; }
        public int IdActividad { get; private set; }

        public E_Inscripcion(int idCliente, int idActividad)
        {
            IdCliente = idCliente;
            IdActividad = idActividad;
        }
    }
}
