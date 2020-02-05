using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdClienteCodigosRecurso
    {
        public int IdRecurso { get; set; }
        public int IdClientesCodificacionRecursos { get; set; }
        public string ClienteCodigoRecurso { get; set; }
    }
}
