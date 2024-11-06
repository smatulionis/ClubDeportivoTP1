using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    class E_NoSocio : E_Cliente
    {
        public E_NoSocio(string nombre, string apellido, string tipoDoc, int documento, bool aptoFisico)
            : base(nombre, apellido, tipoDoc, documento, aptoFisico)
        {
        }
    }
}
