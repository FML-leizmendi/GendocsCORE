using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdClientesCodificacionRecursos
    {
        public int IdClientesCodificacionRecursos { get; set; }
        public int? IdCliente { get; set; }
        public string NombreCodificacion { get; set; }
    }
}
