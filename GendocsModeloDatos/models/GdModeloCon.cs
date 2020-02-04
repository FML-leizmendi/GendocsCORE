using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdModeloCon
    {
        public int IdModeloContenido { get; set; }
        public int? IdEsquema { get; set; }
        public string Contenido { get; set; }
        public decimal? Orden { get; set; }
    }
}
