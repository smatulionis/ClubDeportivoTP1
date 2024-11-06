using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    abstract class E_Cliente
    {
        public int IdCliente { get; private set; }
        public string? Nombre { get; private set; }
        public string? Apellido { get; private set; }
        public string? TipoDoc { get; private set; }
        public int Documento { get; private set; }
        public bool AptoFisico { get; private set; }

        public E_Cliente(string nombre, string apellido, string tipoDoc, int documento, bool aptoFisico)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDoc = tipoDoc;
            Documento = documento;
            AptoFisico = aptoFisico;
        }
    }
}
