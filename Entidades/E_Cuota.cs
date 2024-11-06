using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Cuota
    {
        public int IdCuota { get; private set; }
        public int IdCliente { get; private set; }
        public float Monto { get; private set; }
        public DateTime Fecha { get; private set; }
        public string? FormaPago { get; private set; }

        public E_Cuota(int idCliente, string formaPago)
        {
            IdCliente = idCliente;
            Monto = 10000;
            Fecha = DateTime.Now;
            FormaPago = formaPago;
        }

        public void modificarMonto(float monto)
        {
            Monto = monto;
        }
    }
}
