using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdClientesCodificacionRecursos
    {
        public int IdClientesCodificacionRecursos { get; set; }
        public int? IdCliente { get; set; }
        public string NombreCodificacion { get; set; }
    }
}
