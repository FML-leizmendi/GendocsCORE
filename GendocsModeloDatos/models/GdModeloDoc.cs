using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class GdModeloDoc
    {
        public int IdModeloDoc { get; set; }
        public string CodModeloDoc { get; set; }
        public string ModeloDocumento { get; set; }
        public decimal? Orden { get; set; }
        public string ModeloWord { get; set; }
        public string CarpetaDestino { get; set; }
    }
}
