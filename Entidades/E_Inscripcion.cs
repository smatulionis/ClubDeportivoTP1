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
        public int IdInscripcion { get; set; }
        public int IdCliente { get; set; }
        public int IdActividad { get; set; }
        public bool Pagado { get; set; }

        public E_Inscripcion()
        {
            Pagado = false;
        }
    }
}
