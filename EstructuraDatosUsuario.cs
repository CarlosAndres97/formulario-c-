using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3CarlosSoriano
{
    public class EstructuraDatosUsuario
    {
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Edad { get; set; }
        public int Estrato { get; set; }
        public string? AtencionRequerida { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int ValorCopago {get; set;}



    }
}
