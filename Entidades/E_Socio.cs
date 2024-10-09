using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    public class E_Socio
    {
        public int IdSocio { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? TipoDoc { get; set; }
        public int Documento { get; set; }
    }
}
