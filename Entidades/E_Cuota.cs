using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Cuota
    {
        public int IdCuota { get; set; }
        public int IdCliente { get; set; }
        public float Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string? FormaPago { get; set; }

        public E_Cuota()
        {
            Fecha = DateTime.Now;
            Monto = 10000;
        }
    }
}
